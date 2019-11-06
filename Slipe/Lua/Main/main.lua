require = function() end

local isServer = triggerServerEvent == nil
local isClient = not isServer

local allClasses = {}	
local mainString	

local oldInit = System.init	

local prepareInit = function(classes)	
	for _, class in ipairs(classes) do	
		allClasses[#allClasses + 1] = class	
	end	
end	

 local finalizeInit = function(classes, settings)	
	for _, class in ipairs(classes) do	
		allClasses[#allClasses + 1] = class	
	end	
	mainString = settings.Main	
	oldInit(allClasses, settings)	
end

function prepareManifest(filepath)
	if not fileExists(filepath) then
		return
	end
	System.init = prepareInit	
	local file = fileOpen(filepath)
	local content = fileRead(file, fileGetSize(file))
	fileClose(file)
	local result = loadstring(content)
	result()()
end

function finalizeManifest(filepath)
	if not fileExists(filepath) then
		return
	end
	System.init = finalizeInit
	local file = fileOpen(filepath)
	local content = fileRead(file, fileGetSize(file))
	fileClose(file)
	local result = loadstring(content)
	result()()
end

function prepareModule(path)
	local path = path .. "/Lua/Compiled/" .. ( isServer and "Server" or "Client") .. "/manifest.lua"
	prepareManifest(path)
end
for _, modulePath in ipairs(moduleTable) do
	prepareModule(modulePath)
end

local mainManifest = isServer and "Dist/Server/manifest.lua" or "Dist/Client/manifest.lua"
finalizeManifest(mainManifest)

function runEntryPoint()
	if (isClient) then
		-- instantiate the local player to ensure ElementManager.GetElement will always return a LocalPlayer instance
		local localPlayer = Slipe.Client.Peds.LocalPlayer.getInstance()
	end

	local stringEntryPoint = System.entryPoint

	local splits = split(stringEntryPoint, ".") 
	local result = _G 
	for _, split in ipairs(splits) do 
		result = result[split] 
	end
	result()

	-- Let the server know we are ready to accept incoming rpcs
	if(triggerServerEvent ~= nil) then
		Slipe.Client.Rpc.RpcManager.getInstance()
		triggerServerEvent("slipe-client-ready-rpc", root)
	else
		Slipe.Server.Rpc.RpcManager.getInstance()
		addEvent("slipe-client-ready-rpc", true)	
	end

end
initEvents()
runEntryPoint()
