local System = System
local MySqlConnectionString = {}

MySqlConnectionString.__ctor__ = function(this)

end

MySqlConnectionString.getDbName = function (this)
  return this.dbName
end
MySqlConnectionString.setDbName = function (this, value)
  this.dbName = value
end

MySqlConnectionString.getHostname = function (this)
  return this.hostname
end
MySqlConnectionString.setHostname = function (this, value)
  this.hostname = value
end

MySqlConnectionString.getPort = function (this)
  return this.port
end
MySqlConnectionString.setPort = function (this, value)
  this.port = value
end

MySqlConnectionString.getUnix_socket = function (this)
  return this.unixSocket
end
MySqlConnectionString.setUnix_socket = function (this, value)
  this.unixSocket = value
end

MySqlConnectionString.getCharset = function (this)
  return this.charset
end
MySqlConnectionString.setCharset = function (this, value)
  this.charset = value
end

System.define("Slipe.Sql.MySqlConnectionString", MySqlConnectionString)