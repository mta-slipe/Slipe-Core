--[[
Copyright 2017 YANG Huan (sy.yanghuan@gmail.com).

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

  http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
--]]

local System = System
local define = System.define
local throw = System.throw
local each = System.each

local IOException = define("System.IO.IOException", {
  __tostring = System.Exception.ToString,
  __inherits__ = { System.Exception },
  __ctor__ = function(this, message, innerException) 
    System.Exception.__ctor__(this, message or "I/O error occurred.", innerException)
  end,
})

local File = {}

function File.ReadAllBytes(path)
  local file = fileOpen(path, true)
  local contents = fileRead(file, fileGetSize(file))
  fileClose(file)
  return contents
end

function File.ReadAllText(path)
  local file = fileOpen(path, true)
  local contents = fileRead(file, fileGetSize(file))
  fileClose(file)
  return contents
end

function File.ReadAllLines(path)
  local file = fileOpen(path, true)
  local contents = fileRead(file, fileGetSize(file))
  fileClose(file)
  return System.arrayFromTable(split(contents, "\n"), "System.String")
end

function File.WriteAllBytes(path, contents)
  local file = fileOpen(path)
  fileWrite(file, contents)
  fileClose(file)
end

function File.WriteAllText(path, contents)
  local file = fileOpen(path)
  fileWrite(file, contents)
  fileClose(file)
end

function File.WriteAllLines(path, contents)
  local file = fileOpen(path)
  for _, line in each(contents) do
    if line == nil then
      fileWrite(file, "\n")
    else
      fileWrite(file, line .. "\n")
    end
  end
  fileClose(file)
end

function File.Copy(pathFrom, pathTo, overwrite)
  fileCopy(pathFrom, pathTo, overwrite)
end

function File.Exists(path)
  return fileExists(path)
end

function File.Delete(path)
  return fileDelete(path)
end

define("System.IO.File", File)
