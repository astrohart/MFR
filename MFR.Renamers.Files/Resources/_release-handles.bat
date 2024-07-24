@echo off
for /f "tokens=3,6,8 delims=: " %%i in ('handle /accepteula -p $PROCESS$ "$FOLDER$"') do echo Releasing %%k & handle -c %%j -y -p %%i