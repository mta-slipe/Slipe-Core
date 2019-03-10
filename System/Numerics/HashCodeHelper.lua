local System = System
local bitLShift = bitLShift
local bitNot = bitNot

local HashCodeHelper = {}

function HashCodeHelper.CombineHashCodes(h1, h2)
    return (bitLShift(h1, 5) + h1) * bitNot(h2)
end

System.define("System.Numerics.HashCodeHelper", HashCodeHelper)