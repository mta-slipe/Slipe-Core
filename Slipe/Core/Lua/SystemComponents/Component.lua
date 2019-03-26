local System = System
local System_ComponentModel = System.ComponentModel

local EventDisposed, __gc, getCanRaiseEvents, getCanRaiseEventsInternal, addDisposed, removeDisposed, getEvents, getSite, 
setSite, Dispose, Dispose1, getContainer, GetService, getDesignMode, ToString, static

static = function (this)
    EventDisposed = System.Object()
end

__gc = function (this)
    Dispose1(this, false)
end

getCanRaiseEvents = function (this)
    return true
end

getCanRaiseEventsInternal = function (this)
    return getCanRaiseEvents(this)
end

addDisposed = function (this, value)
    getEvents(this):AddHandler(EventDisposed, value)
end

removeDisposed = function (this, value)
    getEvents(this):RemoveHandler(EventDisposed, value)
end

getEvents = function (this)
    if this.events == nil then
        this.events = System.new(System_ComponentModel.EventHandlerList, 2, this)
    end
    return this.events
end

getSite = function (this)
    return this.site
end

setSite = function (this, value)
    this.site = value
end

Dispose = function (this)
    Dispose1(this, true)
    System.GC.SuppressFinalize(this)
end

Dispose1 = function (this, disposing)
    if disposing then
    -- lock(this)
        do
            if this.site ~= nil and this.site:getContainer() ~= nil then
                this.site:getContainer():Remove(this)
            end
            if this.events ~= nil then
                local handler = System.cast(System.Delegate, this.events:get(EventDisposed))
                if handler ~= nil then
                    handler(this, System.EventArgs.Empty)
                end
            end
        end
    end
end

getContainer = function (this)
    local s = this.site
    local default
    if s == nil then
        default = nil
    else
        default = s:getContainer()
    end
    return default
end

GetService = function (this, service)
    local s = this.site
    local default
    if (s == nil) then
        default = nil
    else
        default = s:GetService(service)
    end
    return (default)
end

getDesignMode = function (this)
    local s = this.site
    local default
    if (s == nil) then
        default = false
    else
        default = s:getDesignMode()
    end
    return default
end

ToString = function (this)
    local s = this.site

    if s ~= nil then
        return s:getName() .. " [" .. this:GetType():getFullName() .. "]"
    else
        return this:GetType():getFullName()
    end
end

System.define("System.ComponentModel.Component", {
    __inherits__ = function (out)
        return {
          System.Object
        }
      end,
    __gc = __gc,
    getCanRaiseEvents = getCanRaiseEvents,
    getCanRaiseEventsInternal = getCanRaiseEventsInternal,
    addDisposed = addDisposed,
    removeDisposed = removeDisposed,
    getEvents = getEvents,
    getSite = getSite,
    setSite = setSite,
    Dispose = Dispose,
    Dispose1 = Dispose1,
    getContainer = getContainer,
    GetService = GetService,
    getDesignMode = getDesignMode,
    ToString = ToString,
    static = static
})

System.define("System.ComponentModel.ListEntry", {
    __ctor__ = function (this, key, handler, next)
            this.next = next
            this.key = key
            this.handler = handler
        end
})

local get, set, AddHandler, AddHandlers, Dispose, Find, RemoveHandler, class, 
__ctor1__, __ctor2__

__ctor1__ = function (this) end

__ctor2__ = function (this, parent)
    this.parent = parent
end

get = function (this, key)
    local e = nil
        if this.parent == nil or this.parent:getCanRaiseEventsInternal() then
        e = Find(this, key)
    end
    if e ~= nil then
        return e.handler
    else
        return nil
    end
end

set = function (this, key, value)
    local e = Find(this, key)
    if e ~= nil then
        e.handler = value
    else
        this.head = class.ListEntry(key, value, this.head)
    end
end

AddHandler = function (this, key, value)
    local e = Find(this, key)
    if e ~= nil then
        e.handler = System.Delegate.Combine(e.handler, value)
    else
        this.head = class.ListEntry(key, value, this.head)
    end
end

AddHandlers = function (this, listToAddFrom)
    local currentListEntry = listToAddFrom.head
    while currentListEntry ~= nil do
        AddHandler(this, currentListEntry.key, currentListEntry.handler)
        currentListEntry = currentListEntry.next
    end
end

Dispose = function (this)
    this.head = nil
end

Find = function (this, key)
    local found = this.head
    while found ~= nil do
        if found.key == key then
            break
        end
        found = found.next
    end
    return found
end

RemoveHandler = function (this, key, value)
    local e = Find(this, key)
    if e ~= nil then
        e.handler = System.Delegate.Remove(e.handler, value)
    end
end

System.define("System.ComponentModel.EventHandlerList", {
    get = get,
    set = set,
    AddHandler = AddHandler,
    AddHandlers = AddHandlers,
    Dispose = Dispose,
    RemoveHandler = RemoveHandler,
    __ctor__ = {
        __ctor1__,
        __ctor2__
    }
})


