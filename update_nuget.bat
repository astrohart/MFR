@ECHO OFF
REM
REM _update-all-nugets.bat - Iterates over the subdirectories of the folder in
REM which this batch file lives.  It does just the topmost-level subfolders.
REM For each folder, this batch file calls update-nuget.cmd, which uses the 
REM NuGet CLI environment to update and install the latest version of all
REM projects' NuGet packages.  Then, you can go ahead and do a replace in files
REM or check in the changes etc.
REM
REM NOTE: If this is in the \users\source\repos\astrohart folder, ALL solutions
REM within the folder will be processed.  To process just one solution, simply 
REM copy the update-nuget.bat and update-nuget.cmd files to the proper folder.
REM
:SETUP_VARIABLES
SET "UPDATE_SCRIPT_PATH=%~dp0update_nuget.cmd"
:CHECK_REQUIRED_FILES_AND_FOLDERS_EXIST
IF NOT EXIST "%UPDATE_SCRIPT_PATH%" (
    ECHO Setup could not locate a required file.  Setup will now close.
    ECHO File needed: "%UPDATE_SCRIPT_PATH%"
    ECHO.
    PAUSE
    ECHO.
    SET ERRORLEVEL=-1
    GOTO :EOF
)
:MAIN
:INIT_INSTANCE
PUSHD "%~dp0"
SETLOCAL ENABLEDELAYEDEXPANSION
:PARSE_COMMAND_LINE
:PROCESS_COMMAND_LINE
ECHO Setup is updating and re-installing NuGet packages...  This may take a while.
ECHO.
for /d %%x in (*) do (
    set "dname=%%x"
    PUSHD "%~dp0!dname!"
    ECHO Setup is updating packages for projects in folder '%~dp0!dname!'...
    IF EXIST "%UPDATE_SCRIPT_PATH%" CALL "%UPDATE_SCRIPT_PATH%"
    POPD
)
POPD