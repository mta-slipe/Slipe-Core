local System = System
local System_Numerics = System.Numerics
local abs = math.abs
local min = math.min
local max = math.max
local sqrt = math.sqrt

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
Vector3.getOne = function() return new(Vector3, 1.0, 1.0, 1.0) end
Vector3.getZero = function() return new(Vector3, 0, 0, 0) end
Vector3.getUnitX = function() return new(Vector3, 1.0, 0.0, 0.0) end
Vector3.getUnitY = function() return new(Vector3, 0.0, 1.0, 0.0) end
Vector3.getUnitZ = function() return new(Vector3, 0.0, 0.0, 1.0) end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.copyto?view=netframework-4.7.2#System_Numerics_Vector3_CopyTo_System_Single___
function Vector3.CopyTo(this, array, index)
    if index == nil then
        index = 0
    end

    if array == nil then
        System.throw(System.NullReferenceException())
    end

    if index < 0 or index >= #array then
        System.throw(System.ArgumentOutOfRangeException())
    end
    if (#array - index) < 3 then
        System.throw(System.ArgumentException())
    end

    array:set(index, this.X)
    array:set(index + 1, this.Y)
    array:set(index + 2, this.Z)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.equals?view=netframework-4.7.2#System_Numerics_Vector3_Equals_System_Object_
function Vector3.Equals(this, other)
    if not (System.is(other, Vector3)) then
        return false
    end
    other = System.cast(Vector3, other)
    return this.X == other.X and this.Y == other.Y and this.Z == other.Z
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.dot?view=netframework-4.7.2#System_Numerics_Vector3_Dot_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.Dot(vector1, vector2)
    return vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z * vector2.Z
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.min?view=netframework-4.7.2#System_Numerics_Vector3_Min_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.Min(value1, value2)
    return new(Vector3, (value1.X < value2.X) and value1.X or value2.X, (value1.Y < value2.Y) and value1.Y or value2.Y, (value1.Z < value2.Z) and value1.Z or value2.Z)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.max?view=netframework-4.7.2#System_Numerics_Vector3_Max_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.Max(value1, value2)
    return new(Vector3, (value1.X > value2.X) and value1.X or value2.X, (value1.Y > value2.Y) and value1.Y or value2.Y, (value1.Z > value2.Z) and value1.Z or value2.Z)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.abs?view=netframework-4.7.2#System_Numerics_Vector3_Abs_System_Numerics_Vector3_
function Vector3.Abs(value)
    return new(Vector3, abs(value.X), abs(value.Y), abs(value.Z))
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.squareroot?view=netframework-4.7.2#System_Numerics_Vector3_SquareRoot_System_Numerics_Vector3_
function Vector3.SquareRoot(value)
    return new(class, System.ToSingle(math.Sqrt(value.X)), System.ToSingle(math.Sqrt(value.Y)), System.ToSingle(math.Sqrt(value.Z)))
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.add?view=netframework-4.7.2#System_Numerics_Vector3_Add_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.op_Addition(left, right)
    return new(Vector3, left.X + right.X, left.Y + right.Y, left.Z + right.Z)
end

function Vector3.Add(left, right)
    return Vector3.op_Addition(left, right)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.subtract?view=netframework-4.7.2#System_Numerics_Vector3_Subtract_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.op_Subtraction(left, right)
    return new(Vector3, left.X - right.X, left.Y - right.Y, left.Z - right.Z)
end

function Vector3.Substract(left, right)
    return Vector3.op_Subtraction(left, right)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.multiply?view=netframework-4.7.2#System_Numerics_Vector3_Multiply_System_Single_System_Numerics_Vector3_
function Vector3.op_Multiply(left, right)
    if type(left) == "number" then
        left = new(Vector3, left)
    end

    if type(right) == "number" then
        right = new(Vector3, right)
    end
    return new(Vector3, left.X * right.X, left.Y * right.Y, left.Z * right.Z)
end

function Vector3.Multiply(left, right)
    return Vector3.op_Multiply(left, right)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.divide?view=netframework-4.7.2#System_Numerics_Vector3_Divide_System_Numerics_Vector3_System_Single_
function Vector3.op_Division(left, right)
    if type(right) == "number" then
        return Vector3.op_Multiply(left, 1.0 / right)
    end
    return new(Vector3, left.X / right.X, left.Y / right.Y, left.Z / right.Z)
end

function Vector3.Divide(left, right)
    return Vector3.op_Division(left, right)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.negate?view=netframework-4.7.2#System_Numerics_Vector3_Negate_System_Numerics_Vector3_
function Vector3.op_UnaryNegation(value)
    return op_Subtraction(Vector3.getZero(), value)
end

function Vector3.Negate(value)
    return - value
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.equals?view=netframework-4.7.2#System_Numerics_Vector3_Equals_System_Numerics_Vector3_
function Vector3.op_Equality(left, right)
    return (left.X == right.X and left.Y == right.Y and left.Z == right.Z)
end

function Vector3.op_Inequality(left, right)
    return (left.X ~= right.X or left.Y ~= right.Y or left.Z ~= right.Z)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.gethashcode?view=netframework-4.7.2#System_Numerics_Vector3_GetHashCode
function Vector3.GetHashCode(this)
    local hash = this.X:GetHashCode()
    hash = System_Numerics.HashCodeHelper.CombineHashCodes(hash, this.Y:GetHashCode())
    hash = System_Numerics.HashCodeHelper.CombineHashCodes(hash, this.Z:GetHashCode())
    return hash
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.tostring?view=netframework-4.7.2#System_Numerics_Vector3_ToString
function Vector3.ToString(this)
    local sb = System.StringBuilder()
    local separator = 44 --[[',']]
    sb:AppendChar(60 --[['<']])
    sb:Append((this.X):ToString())
    sb:AppendChar(separator)
    sb:AppendChar(32 --[[' ']])
    sb:Append((this.Y):ToString())
    sb:AppendChar(separator)
    sb:AppendChar(32 --[[' ']])
    sb:Append((this.Z):ToString())
    sb:AppendChar(62 --[['>']])
    return sb:ToString()
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.length?view=netframework-4.7.2#System_Numerics_Vector3_Length
function Vector3.Length(this)
    local ls = this.X * this.X + this.Y * this.Y + this.Z * this.Z
    return System.ToSingle(sqrt(ls))
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.lengthsquared?view=netframework-4.7.2#System_Numerics_Vector3_LengthSquared
function Vector3.LengthSquared(this)
    return this.X * this.X + this.Y * this.Y + this.Z * this.Z
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.distance?view=netframework-4.7.2#System_Numerics_Vector3_Distance_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.Distance(value1, value2)
    local dx = value1.X - value2.X
    local dy = value1.Y - value2.Y
    local dz = value1.Z - value2.Z

    local ls = dx * dx + dy * dy + dz * dz

    return System.ToSingle(sqrt(ls))
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.distancesquared?view=netframework-4.7.2#System_Numerics_Vector3_DistanceSquared_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.DistanceSquared(value1, value2)
    local dx = value1.X - value2.X
    local dy = value1.Y - value2.Y
    local dz = value1.Z - value2.Z

    return dx * dx + dy * dy + dz * dz
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.normalize?view=netframework-4.7.2#System_Numerics_Vector3_Normalize_System_Numerics_Vector3_
function Vector3.Normalize(this)
    local ls = value.X * value.X + value.Y * value.Y + value.Z * value.Z
    local length = System.ToSingle(sqrt(ls))
    return new(Vector3, value.X / length, value.Y / length, value.Z / length)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.cross?view=netframework-4.7.2#System_Numerics_Vector3_Cross_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.Cross(vector1, vector2)
    return new(Vector3, vector1.Y * vector2.Z - vector1.Z * vector2.Y, vector1.Z * vector2.X - vector1.X * vector2.Z, vector1.X * vector2.Y - vector1.Y * vector2.X)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.reflect?view=netframework-4.7.2#System_Numerics_Vector3_Reflect_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.Reflect(vector, normal)
    local dot = vector.X * normal.X + vector.Y * normal.Y + vector.Z * normal.Z
    local tempX = normal.X * dot * 2
    local tempY = normal.Y * dot * 2
    local tempZ = normal.Z * dot * 2
    return new(Vector3, vector.X - tempX, vector.Y - tempY, vector.Z - tempZ)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.clamp?view=netframework-4.7.2#System_Numerics_Vector3_Clamp_System_Numerics_Vector3_System_Numerics_Vector3_System_Numerics_Vector3_
function Vector3.Clamp(value1, min, max)
    local x = value1.X
    x = (x > max.X) and max.X or x
    x = (x < min.X) and min.X or x

    local y = value1.Y
    y = (y > max.Y) and max.Y or y
    y = (y < min.Y) and min.Y or y

    local z = value1.Z
    z = (z > max.Z) and max.Z or z
    z = (z < min.Z) and min.Z or z

    return new(Vector3, x, y, z)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.lerp?view=netframework-4.7.2#System_Numerics_Vector3_Lerp_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_
function Vector3.Lerp(value1, value2, amount)
    return new(Vector3, value1.X + (value2.X - value1.X) * amount, value1.Y + (value2.Y - value1.Y) * amount, value1.Z + (value2.Z - value1.Z) * amount)
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.transform?view=netframework-4.7.2#System_Numerics_Vector3_Transform_System_Numerics_Vector3_System_Numerics_Matrix4x4_
-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.transform?view=netframework-4.7.2#System_Numerics_Vector3_Transform_System_Numerics_Vector3_System_Numerics_Quaternion_
function Vector3.Transform(position, matrix)
    if rotation.X then
        -- quaternion
        local x2 = rotation.X + rotation.X
        local y2 = rotation.Y + rotation.Y
        local z2 = rotation.Z + rotation.Z
  
        local wx2 = rotation.W * x2
        local wy2 = rotation.W * y2
        local wz2 = rotation.W * z2
        local xx2 = rotation.X * x2
        local xy2 = rotation.X * y2
        local xz2 = rotation.X * z2
        local yy2 = rotation.Y * y2
        local yz2 = rotation.Y * z2
        local zz2 = rotation.Z * z2
  
        return new(Vector3, value.X * (1.0 - yy2 - zz2) + value.Y * (xy2 - wz2) + value.Z * (xz2 + wy2), 
                            value.X * (xy2 + wz2) + value.Y * (1.0 - xx2 - zz2) + value.Z * (yz2 - wx2), 
                            value.X * (xz2 - wy2) + value.Y * (yz2 + wx2) + value.Z * (1.0 - xx2 - yy2)
                        )
    else
        -- 4x4 matrix
        return new(Vector3, position.X * matrix.M11 + position.Y * matrix.M21 + position.Z * matrix.M31 + matrix.M41, 
                            position.X * matrix.M12 + position.Y * matrix.M22 + position.Z * matrix.M32 + matrix.M42, 
                            position.X * matrix.M13 + position.Y * matrix.M23 + position.Z * matrix.M33 + matrix.M43
                        ) 
    end 
end

-- https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.transformnormal?view=netframework-4.7.2#System_Numerics_Vector3_TransformNormal_System_Numerics_Vector3_System_Numerics_Matrix4x4_
function Vector3.TransformNormal(normal, matrix)
    return new(Vector3, normal.X * matrix.M11 + normal.Y * matrix.M21 + normal.Z * matrix.M31,
                        normal.X * matrix.M12 + normal.Y * matrix.M22 + normal.Z * matrix.M32, 
                        normal.X * matrix.M13 + normal.Y * matrix.M23 + normal.Z * matrix.M33
                    )
end

System.defStc("System.Numerics.Vector3", Vector3)
