local System = System

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
    return new(Vector3, math.abs(v.X), math.abs(v.Y), math.abs(v.Z))
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.add?view=netframework-4.7.2#System_Numerics_Vector3_Add_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.Add(v1, v2)
    return new(Vector3, v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z)
end

function Vector3.op_Addition(v1, v2)
    return Vector3.Add(v1, v2)
end

System.defStc("System.Numerics.Vector3", Vector3)
