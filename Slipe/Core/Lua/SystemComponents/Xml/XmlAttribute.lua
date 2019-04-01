local XmlAttribute = {}

XmlAttribute.__inherits__ = { System.Xml.XmlNode }

XmlAttribute.__ctor__ = function(this, prefix, localName, namespaceURI, doc)
	this.owner = document
	this.children = {}
	this.attributes = System.Xml.XmlAttributeCollection()
	this.name = prefix .. ":" .. name
	this.namespaceURI = namespace
end

System.define("System.Xml.XmlAttribute", XmlAttribute)