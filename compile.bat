@echo off

REM Create symlinks if they do not yet exist
IF not EXIST ".\Symlinks" call .\symlinks.bat

REM Remove obj folders
rmdir Resource\MTACore\obj /s /q > nul 2>&1
rmdir Resource\MTASharedWrapper\obj /s /q > nul 2>&1
rmdir Resource\MTAClientWrapper\obj /s /q > nul 2>&1
rmdir Resource\MTAClientResource\obj /s /q > nul 2>&1
rmdir Resource\MTAServerWrapper\obj /s /q > nul 2>&1
rmdir Resource\MTAServerResource\obj /s /q > nul 2>&1

REM Compile from symlink directories
dotnet .\Compiler\CSharp.lua.Launcher.dll -s .\Symlinks\Server -d .\Dist\Server -l .\Symlinks\Server\MTAServerResource\bin\Debug\netcoreapp3.0\MTACore.dll;.\Symlinks\Server\MTAServerResource\bin\Debug\netcoreapp3.0\MTASharedWrapper.dll;.\Symlinks\Server\MTAServerResource\bin\Debug\netcoreapp3.0\MTAServerWrapper.dll
dotnet .\Compiler\CSharp.lua.Launcher.dll -s .\Symlinks\Client -d .\Dist\Client -l .\Symlinks\Client\MTAClientResource\bin\Debug\netcoreapp3.0\MTACore.dll;.\Symlinks\Client\MTAClientResource\bin\Debug\netcoreapp3.0\MTASharedWrapper.dll;.\Symlinks\Client\MTAClientResource\bin\Debug\netcoreapp3.0\MTAClientWrapper.dll

REM update meta
.\updateMeta.exe 1 > nul 2>&1

exit 0;