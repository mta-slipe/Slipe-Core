local System = System
local SqlValue = {}

SqlValue.__ctor__ = function(this, value)
	this.value = value
end

SqlValue.op_Implicit = function (this, value)
	return System.cast(System.String, this.value)
end
SqlValue.op_Implicit1 = function (this, value)
	return System.cast(System.Int32, this.value)
end
SqlValue.op_Implicit2 = function (this, value)
	return System.cast(System.Single, this.value)
end

System.define("Slipe.Sql.SqlValue", SqlValue)