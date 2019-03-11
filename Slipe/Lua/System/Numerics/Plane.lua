local System = System
local System_Numerics = System.Numerics

local new = function (cls, ...)
    local this = setmetatable({}, cls)
    return this, cls.__ctor__(this, ...)
end

local Plane = {}



System.defStc("System.Numerics.Plane", Plane)