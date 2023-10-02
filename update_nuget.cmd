@ECHO OFF
REM
REM Assuming that the current directory contains a .sln file of the same name
REM as the folder that is at the lowest level in the directory tree, then 
REM use that name as the name of the .sln file.
REM
for %%f in ("%CD%") do set "LastPartOfFolder=%%~nxf"
SET "_NUGET_EXE_PATH=%ProgramFiles(x86)%\NuGet\nuget.exe"
SET "_PACKAGES_DIR=%CD%\packages"
SET "_SOLUTION_FILE_NAME=%LastPartOfFolder:.VS2019=%.sln"
SET "_SOLUTION_FILE_PATH=%CD%\%_SOLUTION_FILE_NAME%"
IF NOT EXIST "%_SOLUTION_FILE_PATH%" (
    ECHO ERROR: Solution file '%_SOLUTION_FILE_PATH%' could not be found.  Skipping.
    GOTO :EOF
)
IF EXIST "%_PACKAGES_DIR%" RD /S /Q "%_PACKAGES_DIR%"
IF EXIST "%_SOLUTION_FILE_PATH%" IF EXIST "%_NUGET_EXE_PATH%" CALL "%_NUGET_EXE_PATH%" restore %_SOLUTION_FILE_NAME% -PackagesDirectory packages
IF EXIST "%_NUGET_EXE_PATH%" CALL "%_NUGET_EXE_PATH%" install -NoCache
