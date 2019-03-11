local System = System
local System_Numerics = System.Numerics

local new = function (cls, ...)
    local this = setmetatable({}, cls)
    return this, cls.__ctor__(this, ...)
end

local Matrix4x4 = {}



System.defStc("System.Numerics.Matrix4x4", Matrix4x4)