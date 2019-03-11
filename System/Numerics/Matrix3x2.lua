local System = System
local System_Numerics = System.Numerics

local new = function (cls, ...)
    local this = setmetatable({}, cls)
    return this, cls.__ctor__(this, ...)
end

local Matrix3x2 = {}



System.defStc("System.Numerics.Matrix3x2", Matrix3x2)