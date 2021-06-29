@ECHO OFF
REM
REM batchRebuildAll.bat - Batch rebuilds all platforms, all configurations of
REM all projects in the current folder.
REM
:SETUP_VARIABLES
SET "MSBUILD_PATH=%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\MSBuild.exe"
ECHO MSBUILD_PATH = '%MSBUILD_PATH%'
PAUSE