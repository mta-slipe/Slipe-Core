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

local function openFile(path, mode)
end

local function readAll(path, mode)
end

function File.ReadAllBytes(path)
end

function File.ReadAllText(path)
end

function File.ReadAllLines(path)
end

local function writeAll(path, contents, mode)
end

function File.WriteWriteAllBytes(path, contents)
end

function File.WriteAllText(path, contents)
end

function File.WriteAllLines(path, contents)
end

function File.Exists(path)
end

function File.Delete(path)
end

define("System.IO.File", File)
