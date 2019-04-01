local XmlNodeList = {}


XmlNodeList.__ctor__ = function(this)
	this.values = {}
end

XmlNodeList.get = function(this, key)
	return this.values[key]
end  

XmlNodeList.getCount = function(this)
	return #this.values
end

XmlNodeList.Item = function(this, index)
	return this.values[key]
end

XmlNodeList.GetEnumerator = function(this)
	return System.Collection.arrayEnumerator(this.values)
end

System.define("System.Xml.XmlNodeList", XmlNodeList)