local System = System

local Vector3 = {}

function Vector3.__ctor__(this, X, Y, Z)
    this.X = X
    this.Y = Y
    this.Z = Z
end

System.defStc("System.Numerics.Vector3", Vector3)