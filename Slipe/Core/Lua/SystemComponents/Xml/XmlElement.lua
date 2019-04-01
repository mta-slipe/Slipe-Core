local XmlElement = {}


XmlElement.__ctor__ = function(this, prefix, name, nameSpace, document)
	this.document = document
	this.children = {}
	this.attributes = {}

end

XmlElement.SetAttribute = function (this, name, value)
	this.attributes[name] = value
end

XmlElement.GetAttribute = function (this, name)
	return this.attributes[name]
end

System.define("System.Xml.XmlElement", function(T) 
	local cls = {
		__inherits__ = { System.Xml.XmlNode }
	}
	return cls
end, XmlElement)