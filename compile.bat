@echo off

REM Create symlinks if they do not yet exist
IF not EXIST ".\Symlinks" call .\symlinks.bat

del /s *.notcs

REM Temporarily rename .cs file in obj folders to have them not be compiled
ren .\Resource\MTACore\obj\Debug\netcoreapp3.0\*.cs *.notcs 
ren .\Resource\MTASharedWrapper\obj\Debug\netcoreapp3.0\*.cs *.notcs 
ren .\Resource\MTAClientWrapper\obj\Debug\netcoreapp3.0\*.cs *.notcs 
ren .\Resource\MTAClientResource\obj\Debug\netcoreapp3.0\*.cs *.notcs 
ren .\Resource\MTAServerWrapper\obj\Debug\netcoreapp3.0\*.cs *.notcs
ren .\Resource\MTAServerResource\obj\Debug\netcoreapp3.0\*.cs *.notcs 

REM Compile from symlink directories
dotnet .\Compiler\CSharp.lua.Launcher.dll -s .\Symlinks\Server -d .\Dist\Server -l .\Symlinks\Server\MTAServerResource\bin\Debug\netcoreapp3.0\MTACore.dll;.\Symlinks\Server\MTAServerResource\bin\Debug\netcoreapp3.0\MTASharedWrapper.dll;.\Symlinks\Server\MTAServerResource\bin\Debug\netcoreapp3.0\MTAServerWrapper.dll
dotnet .\Compiler\CSharp.lua.Launcher.dll -s .\Symlinks\Client -d .\Dist\Client -l .\Symlinks\Client\MTAClientResource\bin\Debug\netcoreapp3.0\MTACore.dll;.\Symlinks\Client\MTAClientResource\bin\Debug\netcoreapp3.0\MTASharedWrapper.dll;.\Symlinks\Client\MTAClientResource\bin\Debug\netcoreapp3.0\MTAClientWrapper.dll


REM Rename them back
ren .\Resource\MTACore\obj\Debug\netcoreapp3.0\*.notcs *.cs 
ren .\Resource\MTASharedWrapper\obj\Debug\netcoreapp3.0\*.notcs *.cs 
ren .\Resource\MTAClientWrapper\obj\Debug\netcoreapp3.0\*.notcs *.cs 
ren .\Resource\MTAClientResource\obj\Debug\netcoreapp3.0\*.notcs *.cs 
ren .\Resource\MTAServerWrapper\obj\Debug\netcoreapp3.0\*.notcs *.cs 
ren .\Resource\MTAServerResource\obj\Debug\netcoreapp3.0\*.notcs *.cs 

REM update meta
.\updateMeta.exe 1 > nul 2>&1

exit 0;