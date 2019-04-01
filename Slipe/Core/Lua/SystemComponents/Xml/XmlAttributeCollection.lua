local XmlAttributeCollection = {}


XmlAttributeCollection.__ctor__ = function(this)
	this.values = {}
end

XmlAttributeCollection.get = function(this, key)
	return this.values[key]
end  

XmlAttributeCollection.set = function(this, key, value)
	this.values[key] = value
end  

System.define("System.Xml.XmlAttributeCollection", XmlAttributeCollection)