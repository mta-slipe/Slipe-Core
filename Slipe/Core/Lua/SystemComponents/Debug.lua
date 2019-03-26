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

local select = select
local string = string
local byte = string.byte
local char = string.char

local Debug = {}

function Debug.Write(...)
  outputDebugString(System.String.Format(...))
end

function Debug.WriteIf(expression, ...)
  if not expression then
    return
  end
  outputDebugString(System.String.Format(...))
end

function Debug.WriteLine(...)
  outputDebugString(System.String.Format(...) .. "\n")
end

function Debug.WriteLineIf(expression, ...)
  if not expression then
    return
  end
  outputDebugString(System.String.Format(...) .. "\n")
end

System.define("System.Diagnostics.Debug", Debug)
