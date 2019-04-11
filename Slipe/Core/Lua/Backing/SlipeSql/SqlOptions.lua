local System = System
local SqlOptions = {}

SqlOptions.__ctor__ = function(this)

end

SqlOptions.getShare = function (this)
  return this.share
end
SqlOptions.setShare = function (this, value)
  this.share = value
end

SqlOptions.getBatch = function (this)
  return this.batch
end
SqlOptions.setBatch = function (this, value)
  this.batch = value
end

SqlOptions.getAutoReconnect = function (this)
  return this.reconnect
end
SqlOptions.setAutoReconnect = function (this, value)
  this.reconnect = value
end

SqlOptions.getLog = function (this)
  return this.log
end
SqlOptions.setLog = function (this, value)
  this.log = value
end

SqlOptions.getTag = function (this)
  return this.tag
end
SqlOptions.setTag = function (this, value)
  this.tag = value
end

SqlOptions.getSurpress = function (this)
  return this.surpress
end
SqlOptions.setSurpress = function (this, value)
  this.surpress = value
end

SqlOptions.getMulti_statements = function (this)
  return this.multiStatements
end
SqlOptions.setMulti_statements = function (this, value)
  this.multiStatements = value
end
System.define("Slipe.Sql.SqlOptions", SqlOptions)