local System = System
local System_Numerics = System.Numerics

local new = function (cls, ...)
    local this = setmetatable({}, cls)
    return this, cls.__ctor__(this, ...)
end

local Quaternion = {}



System.defStc("System.Numerics.Quaternion", Quaternion)