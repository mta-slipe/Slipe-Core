local System = System
local DictStringString
local ArrayDictStringString
local ArrayObject

System.import(function (out)
  DictStringString = System.Dictionary(System.String, System.String)
  ArrayDictStringString = System.Array(DictStringString)
  ArrayObject = System.Array(System.Object)
end)

local Database = {}

local function getOptionString(options)
  if (options == nil) then
    return ""
  end
  local optionString = ""

  if (options:getShare() ~= nil) then
    optionString = optionString .. "share=" .. (options:getShare() and 1 or 0) .. ";"
  end

  if (options:getBatch() ~= nil) then
    optionString = optionString .. "batch=" .. (options:getBatch() and 1 or 0) .. ";"
  end

  if (options:getAutoReconnect() ~= nil) then
    optionString = optionString .. "autoreconnect=" .. (options:getAutoReconnect() and 1 or 0) .. ";"
  end

  if (options:getLog() ~= nil) then
    optionString = optionString .. "log=" .. (options:getLog() and 1 or 0) .. ";"
  end

  if (options:getMulti_statements() ~= nil) then
    optionString = optionString .. "multi_statements=" .. (options:getMulti_statements() and 1 or 0) .. ";"
  end

  if (options:getTag() ~= nil) then
    optionString = optionString .. "tag=" .. options:getTag() .. ";"
  end
  
  if (options:getSurpress() ~= nil) then
    local surpress = "surpress="
    for _, value in System.each(option.getSurpress()) do
      optionString = surpress .. value .. ","
    end
    if (surpress:len() > 0) then
      surpress = surpress:sub(0, surpress:len() - 1)
    end
    optionString = optionString .. surpress .. ";"
  end
  
  if (optionString == "") then
    return optionString
  end
  return optionString:sub(0, optionString:len() - 1)
end

local function getConnectionString(connectionStringInstance)
  local connectionString = ""

  if (connectionStringInstance:getDbName() ~= nil) then
    connectionString = connectionString .. "dbname=" .. connectionStringInstance:getDbName() .. ";"
  end
  if (connectionStringInstance:getHostname() ~= nil) then
    connectionString = connectionString .. "host=" .. connectionStringInstance:getHostname() .. ";"
  end
  if (connectionStringInstance:getPort() ~= nil) then
    connectionString = connectionString .. "port=" .. connectionStringInstance:getPort() .. ";"
  end
  if (connectionStringInstance:getUnix_socket() ~= nil) then
    connectionString = connectionString .. "unix_socket=" .. connectionStringInstance:getUnix_socket() .. ";"
  end
  if (connectionStringInstance:getCharset() ~= nil) then
    connectionString = connectionString .. "charset=" .. connectionStringInstance:getCharset() .. ";"
  end


  if (connectionString == "") then
    return connectionString
  end
  return connectionString:sub(0, connectionString:len() - 1)
end

local function createResultSet(queryHandle)
  local results = dbPoll(queryHandle, 0)
  local dictionaryArray = ArrayDictStringString:new(#results)

  for i, row in ipairs(results) do 
    local dictionary = DictStringString()

    for key, value in pairs(row) do
      dictionary:set(key, Slipe.Sql.SqlValue(value))
    end

    dictionaryArray:set(i - 1, dictionary)
  end

  return dictionaryArray
end

Database.__ctor__ = {
  function (this, filepath, options)
    this.database = dbConnect("sqlite", filepath, getOptionString(options))
  end,
  function (this, connectionString, username, password, options)
    this.database = dbConnect("mysql", connectionString, username, password, getOptionString(options))
  end,
  function (this, connectionString, username, password, options)
    this.database = dbConnect("mysql", getConnectionString(connectionString), username, password, getOptionString(options))
  end
}

Database.Exec = function (this, query, ...)
  local varargs = {...}
  if (#varargs == 1 and System.is(varargs[1], ArrayObject) ) then
    return this:Exec1(query, varargs[1])
  end
  dbExec(this.database, query, ...)
end

Database.Exec1 = function (this, query, parameters)
  local params = {}
  if parameters	~= nil then
    for _, value in System.each(parameters) do
      params[#params + 1] = value
    end
  end
  dbExec(this.database, query, unpack(params))
end

Database.Query = function (this, query, ...)
  local varargs = {...}
  if (#varargs == 1 and System.is(varargs[1], ArrayObject) ) then
    return this:Query1(query, varargs[1])
  end

  local task, callback = System.Task.Callback(createResultSet)
  dbQuery(callback, this.database, query, ...)

  return task;
end

Database.Query1 = function (this, query, parameters)
  local params = {}

  if parameters	~= nil then
    for _, value in System.each(parameters) do
      params[#params + 1] = value
    end
  end

  local task, callback = System.Task.Callback(createResultSet)
  dbQuery(callback, this.database, query, unpack(params))

  return task;
end

System.define("Slipe.Sql.Database", Database)