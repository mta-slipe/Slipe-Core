local System = System
local abs = math.abs
local min = math.min
local max = math.max

local new = function (cls, ...)
    local this = setmetatable({}, cls)
    return this, cls.__ctor__(this, ...)
end

local Vector3 = {}

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3?view=netframework-4.7.2#constructors
function Vector3.__ctor__(this, X, Y, Z)
    if Z == nil then
        -- 1 var constructor
        if Y == nil then
            this.X = X
            this.Y = X
            this.Z = X
        -- 2 var constructor
        else
            this.X = X.X
            this.Y = X.Y
            this.Z = Y
        end
    -- 3 var constructor
    else
        this.X = X
        this.Y = Y
        this.Z = Z
    end
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3?view=netframework-4.7.2#properties
Vector3.getOne = function() return new(Vector3, 1, 1, 1) end
Vector3.getZero = function() return new(Vector3, 0, 0, 0) end
Vector3.getUnitX = function() return new(Vector3, 1, 0, 0) end
Vector3.getUnitY = function() return new(Vector3, 0, 1, 0) end
Vector3.getUnitZ = function() return new(Vector3, 0, 0, 1) end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.abs?view=netframework-4.7.2#System_Numerics_Vector3_Abs_System_Numerics_Vector3_
function Vector3.Abs(v)
    return new(Vector3, abs(v.X), abs(v.Y), abs(v.Z))
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.add?view=netframework-4.7.2#System_Numerics_Vector3_Add_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.Add(v1, v2)
    return new(Vector3, v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z)
end

function Vector3.op_Addition(v1, v2)
    return Vector3.Add(v1, v2)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.clamp?view=netframework-4.7.2#System_Numerics_Vector3_Clamp_System_Numerics_Vector3_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.Clamp(v, min, max)
    -- This compare order is very important!!!
    -- We must follow HLSL behavior in the case user specified min value is bigger than max value.

    local x = v.X
    if x > max.X then x = max.X end
    if x < min.X then x = min.X end

    local y = v.Y
    if y > max.Y then y = max.Y end
    if y < min.Y then x = min.Y end

    local z = v.Z
    if z > max.Z then x = max.Z end
    if z < min.Z then x = min.Z end

    return new(Vector3, x, y, z)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.copyto?view=netframework-4.7.2#System_Numerics_Vector3_CopyTo_System_Single___
function Vector3.CopyTo(this, array, index)
    if index == nil then
        index = 0
    end

    if array == nil then
        array = System.NullReferenceException()
        array:traceback();
    end

    if index < 0 or index >= #array then
        throw(System.IndexOutOfRangeException())
    end

    if (#array - index) < 3
        throw(System.Exception("Elements In Source Is Greater Than Destination"))
    end

    array[index] = this.Y
    array[index + 1] = this.Y
    array[index + 2] = this.Z
end
System.defStc("System.Numerics.Vector3", Vector3)
