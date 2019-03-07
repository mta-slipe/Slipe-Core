mkdir Symlinks
mkdir Symlinks\Client
mkdir Symlinks\Server

mklink /D .\Symlinks\Server\MTASharedWrapper ..\..\Resource\MTASharedWrapper
mklink /D .\Symlinks\Server\MTAServerWrapper ..\..\Resource\MTAServerWrapper
mklink /D .\Symlinks\Server\MTAServerResource ..\..\Resource\MTAServerResource

mklink /D .\Symlinks\Client\MTASharedWrapper ..\..\Resource\MTASharedWrapper
mklink /D .\Symlinks\Client\MTAClientWrapper ..\..\Resource\MTAClientWrapper
mklink /D .\Symlinks\Client\MTAClientResource ..\..\Resource\MTAClientResource