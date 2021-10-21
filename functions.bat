@ECHO OFF
REM
REM functions.bat - Repository of commonly-utilized subroutines across all our
REM various batch files.  Note: the first two 'ECHO' lines below can be 
REM uncommented for debugging purposes.
REM
REM ECHO The currently executing script is: '%0'.
REM ECHO The current command line is: %*
CALL :%*
EXIT /B
:ACQUIRE_WGET
powershell -ExecutionPolicy RemoteSigned -Command "& { $ProgressPreference='SilentlyContinue'; [Net.ServicePointManager]::SecurityProtocol =[Net.SecurityProtocolType]::Tls12; $ProgressPreference='Continue'; }" >NUL 2>NUL
SETLOCAL
SET "WGET_LOCAL_PATH=%WINDIR%\wget.exe"
SET "WGET_REMOTE_URL=https://eternallybored.org/misc/wget/1.21.1/64/wget.exe"
SET VERBOSE=n
FOR %%A IN (%*) DO (
	IF /I "%%A"=="/verbose" (
		SET VERBOSE=y
	)
)
IF NOT EXIST "%WGET_LOCAL_PATH%" (
	IF /I "%VERBOSE%"=="y" (
		powershell -Command "& { $ProgressPreference='Continue'; [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12; Invoke-WebRequest '%WGET_REMOTE_URL%' -OutFile '%WGET_LOCAL_PATH%'; }"	
	) ELSE (
		powershell -Command "& { $ProgressPreference='SilentlyContinue'; [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12; Invoke-WebRequest '%WGET_REMOTE_URL%' -OutFile '%WGET_LOCAL_PATH%'; $ProgressPreference='Continue'; }"	>NUL 2>NUL
	)
)
IF NOT EXIST "%WGET_LOCAL_PATH%" (	
	ECHO Setup was unable to download a required package. Setup will now close.
	ECHO File needed: "%WGET_LOCAL_PATH%"
	ECHO.
	PAUSE
	ECHO.
	SET ERRORLEVEL=-1
	TASKKILL /IM CMD.EXE /F
)
ENDLOCAL
EXIT /B
:ADD_DOWNLOAD_LINE
SETLOCAL
SET "DEST_FILE_RAW=%~1"
SET "DEST_FILE=%DEST_FILE_RAW:)=^)%"
SET "REMOTE_URL=%~2"
SET "LOCAL_PATH_RAW=%~3"
SET "LOCAL_PATH=%LOCAL_PATH_RAW:)=^)%"
REM
REM Add a line to the .csv file export at the pathname specified in the 
REM DEST_FILE variable.  The line contains an entry for the installation
REM resource whose download URL is in the REMOTE_URL variable.  The line also
REM contains another entry which is the pathname on the local machine, specified
REM in the LOCAL_PATH variable, to which the resource's data should be written.
REM If the file already exists at the local pathname specified by the LOCAL_PATH
REM variable, then we do nothing.
IF NOT DEFINED DEST_FILE_RAW ( ENDLOCAL && EXIT /B )
IF NOT DEFINED REMOTE_URL ( ENDLOCAL && EXIT /B )
IF NOT DEFINED LOCAL_PATH_RAW ( ENDLOCAL && EXIT /B )
IF EXIST "%LOCAL_PATH_RAW%" ( ENDLOCAL && EXIT /B )
ECHO "%REMOTE_URL%","%LOCAL_PATH%">>"%DEST_FILE%"
ENDLOCAL
EXIT /B
:ADD_PATH_TO_REGISTRY
SET FORCE=n
SET INPUT_PATH=
SET ISLITERAL=n
SET KEYARG=
SET PATHARG=
SET REGISTRY_KEY=
SET VALUE_NAME=
SET VALNAMEARG=
SET VERBOSE=n
SET VERYSILENT=n
REM
REM First, we parse command-line arguments.  There is a variable number of 
REM command-line arguments, and some of them take parameters.  We get a count
REM of the arguments here and put it into the variable ARGC.  Then, we parse
REM each argument into a variable called ARGV (to mimic "C").  Then we go one-
REM by-one and attempt to extract any argument parameters.  Parameters should be
REM given as the form /arg:"param" where arg is the switch, and param is the 
REM parameter value being passed.
REM
SET /A ARGC=0
FOR %%X IN (%*) DO SET /A ARGC+=1
IF %ARGC% EQU 0 (
	CALL :SHOW_ERROR_ADD_PATH_TO_REGISTRY_MANDATORY_SWITCHES
)
REM
REM The following loop merely detects toggle switches, i.e., if the switch is
REM even specified on the command line at all, then enable its functionality;
REM if it's not, then disable its functionality.
REM
FOR %%A IN (%*) DO (
	IF /I "%%A"=="/force" (
		SET FORCE=y
	)
	IF /I "%%A"=="/literal" (
		SET ISLITERAL=y
	)
	IF /I "%%A"=="/verbose" (
		SET VERBOSE=y
		SET VERYSILENT=n
	)
	IF /I "%%A"=="/verysilent" (
		SET VERBOSE=n
		SET VERYSILENT=y
	)
)
SETLOCAL EnableExtensions EnableDelayedExpansion
FOR /L %%x IN (1 1 %ARGC%) DO (
	CALL SET ARGV=%%%%x
	IF /I NOT "!ARGV:/key=!"=="!ARGV!" (
		CALL SET KEYARG=!ARGV!
	)
	IF /I NOT "!ARGV:/path=!"=="!ARGV!" (
		CALL SET PATHARG=!ARGV!
	)
	IF /I NOT "!ARGV:/valname=!"=="!ARGV!" (
		CALL SET VALNAMEARG=!ARGV!
	)
)
IF NOT DEFINED KEYARG (
	CALL :SHOW_ERROR_ADD_PATH_TO_REGISTRY_MANDATORY_SWITCHES	
)
IF NOT DEFINED PATHARG (
	CALL :SHOW_ERROR_ADD_PATH_TO_REGISTRY_MANDATORY_SWITCHES	
)
IF NOT DEFINED VALNAMEARG (
	CALL :SHOW_ERROR_ADD_PATH_TO_REGISTRY_MANDATORY_SWITCHES	
)
SETLOCAL DisableDelayedExpansion
IF DEFINED KEYARG (
	FOR /F "tokens=1,* delims=:" %%A IN ("%KEYARG%") DO (
		SET "REGISTRY_KEY=%%~B"
	)
)
IF DEFINED PATHARG (
	FOR /F "tokens=1,* delims=:" %%A IN ("%PATHARG:)=^)%") DO (
		SET "INPUT_PATH=%%~B"
	)
)
IF DEFINED VALNAMEARG (
	FOR /F "tokens=1,* delims=:" %%A IN ("%VALNAMEARG%") DO (
		SET "VALUE_NAME=%%~B"
	)
)
IF NOT DEFINED INPUT_PATH (
	CALL :SHOW_ERROR_ADD_PATH_TO_REGISTRY_MANDATORY_SWITCHES	
)
IF /I "%FORCE%"=="n" (
	IF NOT EXIST "%INPUT_PATH%" (
		ECHO ERROR: The path '%INPUT_PATH:)=^)%' does not exist.
		ECHO This file needs to be present before its pathname can be added to the system Registry.  To suppress this error,
		ECHO pass /force to this script.
		ECHO.
		PAUSE
		ENDLOCAL
		EXIT /B -1
	)
)
IF NOT DEFINED REGISTRY_KEY (
	ENDLOCAL
	EXIT /B
)
IF NOT DEFINED VALUE_NAME (
	ENDLOCAL
	EXIT /B
)
REM
REM Add the data requested by the user to the system Registry.  Note, sometimes,
REM a value name will begin with ^! to signify that the system should: (a)
REM run the launched process as an Administrator, and (b) wait to move on to 
REM anything else until the process thusly launched has been terminated.  The
REM code above sometimes creates a duplicate of the caret (^) character and 
REM this is incorrect.  So, we also do a string-replace on the VALUE_NAME
REM variable to ensure that duplicate caret characters are removed.  We need to
REM do this twice, however; because apparently SETLOCAL DisableDelayedExpansion
REM likes to duplicate any carets TWICE.
REM
REM NOTE: The two lines below have no effect if the value name does not contain
REM caret (^) characters.
REM
SET "VALUE_NAME=%VALUE_NAME:^^=^%"
SET "VALUE_NAME=%VALUE_NAME:^^=^%"
REM
REM OKAY, now add the key and value to the system Registry.
REM
IF /I "%VERYSILENT%"=="n" (
	echo Setup is updating your system...
	echo.
)
IF /I "%VERBOSE%"=="y" (
	IF /I "%ISLITERAL%"=="y" (
		ECHO REG ADD "%REGISTRY_KEY%" /T REG_SZ /V "%VALUE_NAME%" /D "%INPUT_PATH:)=^)%" /F
		REG ADD "%REGISTRY_KEY%" /T REG_SZ /V "%VALUE_NAME%" /D "%INPUT_PATH:)=^)%" /F
	) ELSE (
		ECHO REG ADD "%REGISTRY_KEY%" /T REG_SZ /V "%VALUE_NAME%" /D "\"%INPUT_PATH:)=^)%\"" /F
		REG ADD "%REGISTRY_KEY%" /T REG_SZ /V "%VALUE_NAME%" /D "\"%INPUT_PATH:)=^)%\"" /F
	)
) ELSE (
	IF /I "%ISLITERAL%"=="y" (
		REG ADD "%REGISTRY_KEY%" /T REG_SZ /V "%VALUE_NAME%" /D "%INPUT_PATH:)=^)%" /F >NUL 2>NUL
	) ELSE (
		REG ADD "%REGISTRY_KEY%" /T REG_SZ /V "%VALUE_NAME%" /D "\"%INPUT_PATH:)=^)%\"" /F >NUL 2>NUL
	)
)
ENDLOCAL
EXIT /B
:CENTER_WINDOW
SETLOCAL
SET "_TEMP_FOLDER=%WINDIR%\Temp\{84CFA2BA-E035-40A2-882B-865BC67B4D5A}"
SET "CENTER_WINDOW_SCRIPT_LOCAL_PATH=%_TEMP_FOLDER%\_center-window.bat"
SET "CENTER_WINDOW_SCRIPT_REMOTE_URL=https://www.dropbox.com/s/ktm3baygh72s6cn/_center-window.bat?raw=1"
IF NOT EXIST "%_TEMP_FOLDER%" MKDIR "%_TEMP_FOLDER%" >NUL 2>NUL
IF NOT EXIST "%CENTER_WINDOW_SCRIPT_LOCAL_PATH%" CALL :DOWNLOAD_FILE "%CENTER_WINDOW_SCRIPT_REMOTE_URL%" "%CENTER_WINDOW_SCRIPT_LOCAL_PATH%"
CALL :INSIST_FILE_EXISTS "%CENTER_WINDOW_SCRIPT_LOCAL_PATH%"
IF EXIST "%CENTER_WINDOW_SCRIPT_LOCAL_PATH%" CALL "%CENTER_WINDOW_SCRIPT_LOCAL_PATH%"
IF EXIST "%_TEMP_FOLDER%" RD /S /Q "%_TEMP_FOLDER%" >NUL 2>NUL
ENDLOCAL
EXIT /B
:CLEAR_DIR_IF_EXISTS
SETLOCAL
SET VERBOSE=n
FOR %%A IN (%*) DO (
    IF /I "%%A"=="/verbose" (
        SET VERBOSE=y
    )
)
SET "PATH_TO_FOLDER_TO_CLEAR_RAW=%~1"
SET "PATH_TO_FOLDER_TO_CLEAR=%PATH_TO_FOLDER_TO_CLEAR_RAW:)=^)%
IF NOT DEFINED PATH_TO_FOLDER_TO_CLEAR (
	ECHO ERROR: (CLEAR_FOLDER_IF_EXISTS^): Cannot clear a folder because the path specified is blank.
	ECHO.
	PAUSE
	EXIT /B
)
IF /I "%VERBOSE%"=="y" (
	echo Setup is trying to remove all files and folders from '%PATH_TO_FOLDER_TO_CLEAR%'...
	echo.
)
IF NOT EXIST "%PATH_TO_FOLDER_TO_CLEAR_RAW%" ( MKDIR "%PATH_TO_FOLDER_TO_CLEAR_RAW%" >NUL 2>NUL && EXIT /B )
IF EXIST "%PATH_TO_FOLDER_TO_CLEAR_RAW%" RD /S /Q "%PATH_TO_FOLDER_TO_CLEAR_RAW%" >NUL 2>NUL
IF NOT EXIST "%PATH_TO_FOLDER_TO_CLEAR_RAW%" MKDIR "%PATH_TO_FOLDER_TO_CLEAR_RAW%" >NUL 2>NUL
ENDLOCAL
EXIT /B
:CLEAR_FOLDER_IF_EXISTS
SETLOCAL
SET VERBOSE=n
FOR %%A IN (%*) DO (
    IF /I "%%A"=="/verbose" (
        SET VERBOSE=y
    )
)
SET "PATH_TO_FOLDER_TO_CLEAR_RAW=%~1"
SET "PATH_TO_FOLDER_TO_CLEAR=%PATH_TO_FOLDER_TO_CLEAR_RAW:)=^)%
IF NOT DEFINED PATH_TO_FOLDER_TO_CLEAR (
	ECHO ERROR: (CLEAR_FOLDER_IF_EXISTS^): Cannot clear a folder because the path specified is blank.
	ECHO.
	PAUSE
	EXIT /B
)
IF /I "%VERBOSE%"=="y" (
	echo Setup is trying to remove all files and folders from '%PATH_TO_FOLDER_TO_CLEAR%'...
	echo.
)
IF NOT EXIST "%PATH_TO_FOLDER_TO_CLEAR_RAW%" ( MKDIR "%PATH_TO_FOLDER_TO_CLEAR_RAW%" >NUL 2>NUL && EXIT /B )
IF EXIST "%PATH_TO_FOLDER_TO_CLEAR_RAW%" RD /S /Q "%PATH_TO_FOLDER_TO_CLEAR_RAW%" >NUL 2>NUL
IF NOT EXIST "%PATH_TO_FOLDER_TO_CLEAR_RAW%" MKDIR "%PATH_TO_FOLDER_TO_CLEAR_RAW%" >NUL 2>NUL
ENDLOCAL
EXIT /B
:COPY_FILE
SETLOCAL
SET VERBOSE=n
FOR %%A IN (%*) DO (
    IF /I "%%A"=="/verbose" (
        SET VERBOSE=y
    )
)
SET "DEST_FILE_PATH_RAW=%~2"
SET "DEST_FILE_PATH=%DEST_FILE_PATH_RAW:)=^)%
SET "SRC_FILE_PATH_RAW=%~1"
SET "SRC_FILE_PATH=%SRC_FILE_PATH_RAW:)=^)%"
IF NOT DEFINED DEST_FILE_PATH (
    ECHO ERROR: (COPY_FILE^): Cannot copy a file because the destination path specified is blank.
	ECHO.
	PAUSE
    ECHO.
    SET ERRORLEVEL=-1
    ECHO.
	TASKKILL /IM CMD.EXE /F /T >NUL 2>NUL
)
IF NOT DEFINED SRC_FILE_PATH (
    ECHO ERROR: (COPY_FILE^): Cannot copy a file because the source path specified is blank.
	ECHO.
	PAUSE
    ECHO.
    SET ERRORLEVEL=-1
    ECHO.
	TASKKILL /IM CMD.EXE /F /T >NUL 2>NUL
)
IF NOT EXIST "%SRC_FILE_PATH_RAW%" (
    ECHO ERROR: (COPY_FILE^): Cannot copy a file because the source file cannot be located.
    ECHO File needed: "%SRC_FILE_PATH%"
    ECHO.
    PAUSE
    ECHO.
    SET ERRORLEVEL=-1
    ECHO.
    TASKKILL /IM CMD.EXE /F /T >NUL 2>NUL
)
IF /I "%VERBOSE%"=="y" (
	ECHO Copying '%SRC_FILE_PATH%' -^> '%DEST_FILE_PATH%'...
	ECHO.
)
COPY /Y "%SRC_FILE_PATH_RAW%" "%DEST_FILE_PATH_RAW%" >NUL 2>NUL
SET ERRORLEVEL=0
ENDLOCAL
EXIT /B
:CREATE_DIR_IF_NOT_EXISTS
SETLOCAL
SET "PATH_TO_NEW_FOLDER_RAW=%~1"
SET "PATH_TO_NEW_FOLDER=%PATH_TO_NEW_FOLDER_RAW:)=^)%
SET VERBOSE=n
FOR %%A IN (%*) DO (
	IF /I "%%A"=="/verbose" (
		SET VERBOSE=y
	)
)
IF NOT DEFINED PATH_TO_NEW_FOLDER (
	ECHO ERROR: (CREATE_FOLDER_IF_NOT_EXISTS^): Cannot create a folder because the path specified is blank.
	ECHO.
	PAUSE
	EXIT /B
)
IF /I "%VERBOSE%"=="y" (
	echo Setup is creating the folder '%PATH_TO_NEW_FOLDER%' if it does not already exist...
	echo.
)
IF EXIST "%PATH_TO_NEW_FOLDER_RAW%" EXIT /B
IF NOT EXIST "%PATH_TO_NEW_FOLDER_RAW%" MKDIR "%PATH_TO_NEW_FOLDER_RAW%" >NUL 2>NUL
ENDLOCAL
EXIT /B
:CREATE_FOLDER_IF_NOT_EXISTS
SETLOCAL
SET "PATH_TO_NEW_FOLDER=%~1"
SET VERBOSE=n
FOR %%A IN (%*) DO (
	IF /I "%%A"=="/verbose" (
		SET VERBOSE=y
	)
)
IF NOT DEFINED PATH_TO_NEW_FOLDER (
	ECHO ERROR: (CREATE_FOLDER_IF_NOT_EXISTS^): Cannot create a folder because the path specified is blank.
	ECHO.
	PAUSE
	EXIT /B
)
IF /I "%VERBOSE%"=="y" (
	echo Setup is creating the folder '%PATH_TO_NEW_FOLDER:)=^)%' if it does not already exist...
	echo.
)
IF EXIST "%PATH_TO_NEW_FOLDER%" EXIT /B
IF NOT EXIST "%PATH_TO_NEW_FOLDER%" MKDIR "%PATH_TO_NEW_FOLDER%" >NUL 2>NUL
ENDLOCAL
EXIT /B
:DEQUOTE
REM
REM This subroutine simply removes any double quotes from its first argument.
REM If the argument has no quotes, then this subroutine returns its input with
REM no alteration.  The return value is placed in the _RESULT variable.
REM The input to this command, itself, must ALWAYS be surrounded by double
REM quotes!
REM
SET "INPUT=%~1"
SET "_RESULT=%INPUT%"
EXIT /B
:DOWNLOAD_FILE
powershell -ExecutionPolicy RemoteSigned -Command "& { $ProgressPreference='SilentlyContinue'; [Net.ServicePointManager]::SecurityProtocol =[Net.SecurityProtocolType]::Tls12; $ProgressPreference='Continue'; }" >NUL 2>NUL
CALL :ACQUIRE_WGET
SETLOCAL
SET CLOBBER=y
SET "LOCAL_PATH=%~2"
SET "REMOTE_URL=%~1"
SET VERBOSE=n
SET "WGET_LOCAL_PATH=%WINDIR%\wget.exe"
FOR %%A IN (%*) DO (
	IF /I "%%A"=="/keep-existing" (
		SET CLOBBER=n
	)
	IF /I "%%A"=="/verbose" (
		SET VERBOSE=y
	)
)
IF /I "%VERBOSE%"=="y" (
	echo Setup is attempting to download '%LOCAL_PATH:)=^)%'...
	echo.
)
IF /I "%CLOBBER%"=="y" IF EXIST "%LOCAL_PATH%" ERASE /F /S /Q "%LOCAL_PATH%" >NUL 2>NUL
IF /I "%VERBOSE%"=="y" (
	IF EXIST "%WGET_LOCAL_PATH%" (
		WGET "%REMOTE_URL%" -O "%LOCAL_PATH%" -4 -q --show-progress --no-check-certificate --append-output="%TEMP%\wget-log.txt"
	) ELSE (
		POWERSHELL -COMMAND "& { $ProgressPreference='Continue'; Invoke-WebRequest '%REMOTE_URL%' -OutFile '%LOCAL_PATH:)=^)%'; }"
	)
	echo.
) ELSE (
	IF EXIST "%WGET_LOCAL_PATH%" (
		WGET "%REMOTE_URL%" -O "%LOCAL_PATH%" -4 -q --no-check-certificate --append-output="%TEMP%\wget-log.txt"
	) ELSE (
		POWERSHELL -COMMAND "& { $ProgressPreference='SilentlyContinue'; Invoke-WebRequest '%REMOTE_URL%' -OutFile '%LOCAL_PATH:)=^)%'; $ProgressPreference='Continue'; }" >NUL 2>NUL
	)
)
ENDLOCAL
EXIT /B
:ENABLE_TLS
powershell -ExecutionPolicy RemoteSigned -Command "& { $ProgressPreference='SilentlyContinue'; [Net.ServicePointManager]::SecurityProtocol =[Net.SecurityProtocolType]::Tls12; $ProgressPreference='Continue'; }" >NUL 2>NUL
:ENFORCE_INTERNET_CONNECTION
REM
REM The machine that this script is being run on must be connected to the
REM Internet.  If it's not, then we show an error to the user and die.  The
REM need to download software packages from online sources, coupled with the
REM assumption that we're utilizing this script to install necessary develop-
REM ment software on a VPS, are the primary drivers of this requirement.
REM
ping www.google.com -n 2 -w 1000 | find "time" >NUL 2>NUL
if %ERRORLEVEL%==1 (
	echo ERROR: This script only works if your computer is connected to the Internet.
	echo.
	pause
	echo.
	TASKKILL /IM CMD.EXE /F >NUL 2>NUL
)
EXIT /B
:FIND_FILE_IN_FOLDER
REM
REM This subroutine searches a folder recursively for tha file name provided.
REM the filename is to be passed in %%1 and, if spaces are in the filename, then
REM it is to be enclosed in quotes.  Only the name of the file, not its fully-
REM qualified pathname, is to be passed.  Pass the path to the root folder of
REM the search, in quotes, in %%2.  This algorithm then searches the folder
REM recursively.  If the file is not found in the folder or any of its sub-
REM folders, then ERRORLEVEL is set to -1.  Otherwise, ERRORLEVEL is set to 
REM zero, and the _FOUND_PATH variable is set to the fully-qualified pathname
REM of the file.
REM
SET _FOUND_PATH=
SET "DIR=%~2"
PUSHD "%DIR%"
for /R %%F in (%~1) do (
    IF EXIST "%%F" SET "_FOUND_PATH=%%F"
    IF EXIST "%%F" ( SET ERRORLEVEL=0 & POPD & EXIT /B )
)
SET ERRORLEVEL=-1
SET _FOUND_PATH=
POPD
EXIT /B
:GENERATE_GUID
SET GUID=
FOR /F "delims=" %%A IN ('powershell -ExecutionPolicy RemoteSigned -Command "& { $([guid]::NewGuid().ToString('B').ToUpperInvariant()) }"') DO SET GUID=%%A
IF NOT DEFINED GUID (
	ECHO ERROR: Setup failed to generate a new GUID.
	ECHO.
	PAUSE
	ECHO.
	SET ERRORLEVEL=-1
	TASKKILL /IM CMD.EXE /F /T >NUL 2>NUL
)
EXIT /B
:GET_DIRECTORY_NAME_OF
SET "DIRECTORY_RESULT=%~dp1"
REM
REM Does the result have a trailing backslash?  Of course it does --
REM so remove it.
REM
IF %DIRECTORY_RESULT:~-1%==\ SET DIRECTORY_RESULT=%DIRECTORY_RESULT:~0,-1%
EXIT /B
:GET_FILENAME_OF
SET "FILENAME_RESULT=%~nx1"
SET "FILENAME_RESULT=%FILENAME_RESULT:)=^)%
EXIT /B
:GET_FULLY_QUALIFIED_PATH_OF
SET "PREVIOUS_WORKING_DIR=%CD%"
CD /D "%~dp0" >NUL 2>NUL
SET FULLY_QUALIFIED_PATH_RESULT=%~f1
REM
REM Does the result have a trailing backslash?  If so, then remove it.
REM
IF %FULLY_QUALIFIED_PATH_RESULT:~-1%==\ SET FULLY_QUALIFIED_PATH_RESULT=%FULLY_QUALIFIED_PATH_RESULT:~0,-1%
CD /D "%PREVIOUS_WORKING_DIR%" >NUL 2>NUL
EXIT /B
:INSIST_FOLDER_EXISTS
SETLOCAL
SET "FOLDER_TO_FIND=%~1"
SET "ESCAPED_FOLDER_TO_FIND=%FOLDER_TO_FIND:)=^)%"
SET VERBOSE=n
FOR %%A IN (%*) DO (
	IF /I "%%A"=="/verbose" (
		SET VERBOSE=y
	)
)
IF /I "%VERBOSE%"=="y" (
	echo Setup is checking whether the folder '%ESCAPED_FOLDER_TO_FIND%' exists on disk...
	echo.
)
IF NOT EXIST "%FOLDER_TO_FIND%" (	
	ECHO Setup was unable to locate a required folder.  Setup will now close.
	ECHO Folder needed: "%ESCAPED_FOLDER_TO_FIND%"
	ECHO.
	PAUSE
	ECHO.
	SET ERRORLEVEL=-1
	TASKKILL /IM CMD.EXE /F
)
IF /I "%VERBOSE%"=="y" (
	echo *** SUCCESS *** The folder '%ESCAPED_FOLDER_TO_FIND%' exists on the disk.
	echo.
)
SET ERRORLEVEL=0
ENDLOCAL
EXIT /B
:INSIST_FILE_EXISTS
SETLOCAL
SET "FILE_TO_FIND=%~1"
SET "ESCAPED_FILE_TO_FIND=%FILE_TO_FIND:)=^)%"
SET VERBOSE=n
FOR %%A IN (%*) DO (
	IF /I "%%A"=="/verbose" (
		SET VERBOSE=y
	)
)
IF NOT DEFINED FILE_TO_FIND (
	ECHO FILE_TO_FIND = '%FILE_TO_FIND%'
	PAUSE
	ECHO ERROR: No filename provided to check for existence on the disk.
	ECHO Setup will now close.
	ECHO.
	PAUSE
	ECHO.
	SET ERRORLEVEL=-1
	TASKKILL /IM CMD.EXE /F
	EXIT /B	
)
IF /I "%VERBOSE%"=="y" (
	echo Setup is checking whether the file '%ESCAPED_FILE_TO_FIND%' exists on disk...
	echo.
)
IF NOT EXIST "%FILE_TO_FIND%" (	
	ECHO Setup was unable to locate a required file.  Setup will now close.
	ECHO File needed: "%ESCAPED_FILE_TO_FIND%"
	ECHO.
	PAUSE
	ECHO.
	SET ERRORLEVEL=-1
	TASKKILL /IM CMD.EXE /F
	EXIT /B
)
IF /I "%VERBOSE%"=="y" (
	echo *** SUCCESS *** The file '%ESCAPED_FILE_TO_FIND%' exists on the disk.
	echo.
)
SET ERRORLEVEL=0
ENDLOCAL
EXIT /B
:MOVE_FILE_TO_FOLDER
SETLOCAL
SET "DESTINATION_FOLDER_INPUT=%~2"
SET "DESTINATION_FOLDER=%DESTINATION_FOLDER_INPUT:)=^)%"
SET "FILE_TO_MOVE_INPUT=%~1"
SET "FILE_TO_MOVE=%FILE_TO_MOVE_INPUT:)=^)%"
IF /I "%VERBOSE%"=="y" (
	echo Setup is moving the file '%FILE_TO_MOVE%' to folder '%DESTINATION_FOLDER%'...
	echo.
)
CALL :GET_FILENAME_OF "%FILE_TO_MOVE_INPUT%"
IF NOT EXIST "%DESTINATION_FOLDER_INPUT%\%FILENAME_RESULT%" MOVE /Y "%FILE_TO_MOVE_INPUT%" "%DESTINATION_FOLDER_INPUT%\" >NUL 2>NUL
CALL :INSIST_FILE_EXISTS "%DESTINATION_FOLDER_INPUT%\%FILENAME_RESULT%"
ENDLOCAL
EXIT /B
:READ_FROM_REGISTRY
REM
REM This subroutine reads a value from the system Registry on a Windows machine.
REM The key path to read from, and value name must be specified as the first
REM and second command-line arguments, respectively, and they each must be
REM in double quotes on the command line of this subroutine.  This subroutine
REM can handle spaces.
REM
SET _RESULT=
SET "KEY_PATH=%~1"
SET "VALUE_NAME=%~2"
IF NOT DEFINED KEY_PATH ( SET "_RESULT=" && SET ERRORLEVEL=-1 && EXIT /B )
IF NOT DEFINED VALUE_NAME ( SET "_RESULT=" && SET ERRORLEVEL=-1 && EXIT /B )
reg QUERY "%KEY_PATH%" /v "%VALUE_NAME%" >NUL 2>NUL
REM
REM Verify that the Registry key and value requested actually exists
REM
IF ERRORLEVEL 1 ( SET ERRORLEVEL=-1 && EXIT /B )
FOR /F "usebackq tokens=3,* skip=2" %%L IN (
    `reg query "%KEY_PATH%" /v "%VALUE_NAME%"`
) DO SET "_RESULT=%%M"
SET ERRORLEVEL=0
EXIT /B
:REMOVE_DIRECTORY
SETLOCAL
SET "FOLDER_TO_REMOVE=%~1"
IF NOT EXIST "%FOLDER_TO_REMOVE%" EXIT /B
IF EXIST "%FOLDER_TO_REMOVE%" RD /S /Q "%FOLDER_TO_REMOVE%" >NUL 2>NUL
ENDLOCAL
EXIT /B
:RESTART_SYSTEM
SETLOCAL
IF /I NOT "%~1"=="NOW" (
	SET /A DELAY=%~1
    START " " SHUTDOWN /F /R /T %DELAY%
) ELSE (
	SET /A DELAY=0
    SHUTDOWN /F /R /T %DELAY%
)
ENDLOCAL
EXIT /B
:SHOW_ERROR_COULD_NOT_OBTAIN_FULLY_QUALIFIED_PATH
echo ERROR: Unable to obtain a fully-qualified path to the output file.
echo.
PAUSE
SET ERRORLEVEL=-1
GOTO END
EXIT /B
:SHOW_ERROR_OUTPUT_FILE_BLANK
echo ERROR: The caller of this script must specify the path to an output file on
echo command line of this script as the first parameter passed.  The output file
echo path must be a fully-qualified one.
echo.
PAUSE
SET ERRORLEVEL=-1
GOTO END
EXIT /B
:SHOW_ERROR_ADD_PATH_TO_REGISTRY_MANDATORY_SWITCHES
echo ERROR: You must supply the /key, /valname, and /path switches, along with their parameter
echo values, to the ADD_PATH_TO_REGISTRY subroutine.  Use the optional /force switch to disable
echo checking whether the path provided exists prior to adding it to the Registry.
echo.
echo NOTE: The ADD_PATH_TO_REGISTRY subroutine only adds values that are of type REG_SZ.
echo.
pause
echo.
SET ERRORLEVEL=-1
TASKKILL /IM CMD.EXE /F >NUL 2>NUL
EXIT /B
:SHOW_ERROR_MANDATORY_SWITCHES
echo ERROR: The /output switch is mandatory, unless you're using /? to ask for Help.
echo.
PAUSE
SET ERRORLEVEL=-1
GOTO END
EXIT /B