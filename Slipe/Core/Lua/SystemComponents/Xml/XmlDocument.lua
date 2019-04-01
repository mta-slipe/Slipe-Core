local XmlDocument = {}


XmlDocument.__ctor__ = function(this)
	
end


XmlDocument.CreateElement = function(name)
	return System.Xml.XmlElement("", name, "", this)
end

XmlDocument.AppendChild = function(this, child)
	if this.root ~= nil then
		System.Throw(System.Exception("An XmlDocument can not have mulitple root elements."))
	end
	this.root = child
end

XmlDocument.RemoveChild = function(this, child)
	if this.root == child then
		this.child = nil
	end
end

System.define("System.Xml.XmlDocument", XmlDocument)