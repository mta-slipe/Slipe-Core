require = function() end

function prepareManifest(filepath)
	local file = fileOpen(filepath)
	local content = fileRead(file, fileGetSize(file))
	fileClose(file)
	local result = loadstring(content)
	result()()
end

function finalizeManifest(filepath)
	local file = fileOpen(filepath)
	local content = fileRead(file, fileGetSize(file))
	fileClose(file)
	local result = loadstring(content)
	result()()
end

function prepareModule(path)
	local path = path .. "/Lua/Compiled/" .. ( triggerServerEvent == nil and "Server" or "Client") .. "/manifest.lua"
	prepareManifest(path)
end
prepareModule("Slipe/Core")

local mainManifest = triggerServerEvent == nil and "Dist/Server/manifest.lua" or "Dist/Client/manifest.lua"
finalizeManifest(mainManifest)

if triggerServerEvent == nil then
	ServerTest.Program.Main()
else
	ClientTest.Program.Main()
end

initEvents()