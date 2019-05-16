require = function() end

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
	System.init = prepareInit	
	local file = fileOpen(filepath)
	local content = fileRead(file, fileGetSize(file))
	fileClose(file)
	local result = loadstring(content)
	result()()
end

function finalizeManifest(filepath)
	System.init = finalizeInit
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

function runEntryPoint()
	local stringEntryPoint = System.entryPoint

	local splits = split(stringEntryPoint, ".") 
	local result = _G 
	for _, split in ipairs(splits) do 
		result = result[split] 
	end
	result()
end
runEntryPoint()

initEvents()