local ArraySegment = {}

ArraySegment.__ctor__ = function(this, array)
	this.array = array
end

ArraySegment.get = function(this, i)
	return this.array[i]
end

ArraySegment.set = function(this, i, value)
	this.array[i] = value
end

ArraySegment.op_Implicit = function(array)
	return ArraySegment(array)
end

ArraySegment.getLength = function(this)
	return this.array:getLength()
end

System.defStc("System.ArraySegment", ArraySegment)
System.defStc("System.ArraySegment_1", ArraySegment)