local XmlNode = {}

XmlNode.get = function (this, name)
	for _, child in ipairs(this.children) do
		if child:getName() == name then
			return child
		end
	end
end

XmlNode.getFirstChild = function (this)
	return this.children[1]
end

XmlNode.getIsReadOnly = function (this)
	return false
end

XmlNode.getLastChild = function (this)
	return this.children[#this.children]
end

XmlNode.getLocalName = function (this)
	local splits = split(this.name, ":")
	return splits[#splits]
end

XmlNode.getName = function (this)
	return this.name
end

XmlNode.getNamespaceURI = function (this)
	return ""
end

XmlNode.getNextSibling = function (this)
	return this.nextSibling
end

XmlNode.getNodeType = function (this)
	return this.type
end

XmlNode.getOuterXML = function (this)
	System.Throw(System.NotImplementedException())
end

XmlNode.getOwnerDocument = function (this)
	return this.owner
end

XmlNode.getParentNode = function (this)
	return this.parent
end

XmlNode.getPrefix = function (this)
	local splits = split(this.name, ":")
	if #splits == 1 then
		return ""
	end
	return splits[1]
end

XmlNode.getPreviousSibling = function (this)
	return this.previousSibling
end

XmlNode.getInnerText = function (this)
	return this.value
end

XmlNode.getHasChildNodes = function (this)
	return #this.children > 0
end

XmlNode.getValue = function (this)
	return this.value
end

XmlNode.getChildNodes = function (this)
	return this.children
end

XmlNode.getBaseURI = function (this)
	System.Throw(System.NotImplementedException())
end

XmlNode.getAttributes = function (this)
	return this.attributes
end

XmlNode.getPreviousText = function (this)
	System.Throw(System.NotImplementedException())
end

XmlNode.AppendChild = function (this, element)
	this.children[#this.children + 1] = element
	return element
end

XmlNode.CloneNode = function (this, deep)
	System.Throw(System.NotImplementedException())
end

XmlNode.GetEnumerator = function (this)
	System.Throw(System.NotImplementedException())
end

XmlNode.GetNamespaceOfPrefix = function (this, prefix)
	System.Throw(System.NotImplementedException())
end

XmlNode.GetPrefixOfNamespace = function (this, namespace)
	System.Throw(System.NotImplementedException())
end

XmlNode.InsertAfter = function (this, newChild, refChild)
	System.Throw(System.NotImplementedException())
end

XmlNode.InsertBefore = function (this, newChild, refChild)
	System.Throw(System.NotImplementedException())
end

XmlNode.Normalize = function (this)
	System.Throw(System.NotImplementedException())
end

XmlNode.PrependChild = function (this, newChild)
	System.Throw(System.NotImplementedException())
end

XmlNode.RemoveAll = function (this)
	this.children = {}
	this.attributes = System.Xml.XmlAttributeCollection()
end

XmlNode.RemoveChild = function (this, oldChild)
	System.Throw(System.NotImplementedException())
end

XmlNode.RepalceChild = function (this, newChild, oldChild)
	System.Throw(System.NotImplementedException())
end

XmlNode.Supports = function (this, feature, version)
	return false
end

XmlNode.GetEnumerator = function (this)
	System.Throw(System.NotImplementedException())
end

XmlNode.RemoveChild = function (this, element)
	for i = 1, #this.children do
		if this.children[i] == element then
			table.remove(i)
			return
		end
	end
	return element
end



System.define("System.Xml.XmlNode", XmlNode)