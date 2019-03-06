require = function() end

local file = fileOpen("Resource/dist/manifest.lua")
local content = fileRead(file, fileGetSize(file))
fileClose(file)
local result = loadstring(content)
print(result)
result()()

src.Program.Main()
