local System = System
local SystemTimers = System.Timers
local setTimer = setTimer

local ceil = math.ceil

local getAutoReset, setAutoReset, getEnabled, setEnabled, UpdateTimer, getInterval, setInterval, addElapsed,  
removeElapsed, setSite, getSite, getSynchronizingObject, setSynchronizingObject, BeginInit, Close, Dispose, 
EndInit, Start, Stop, TimeCallback, class, __ctor1__, __ctor2__
   
__ctor__ = function (this, interval)
    System.base(this).__ctor__(this)

    if interval == nil then
        this.interval = 100
    else
        if interval <= 0 then
            System.throw(System.ArgumentException())
        end
    
        local roundedInterval = math.ceil(interval)
        if roundedInterval > 2147483647 --[[Int32.MaxValue]] or roundedInterval <= 0 then
            System.throw(System.ArgumentException())
        end
    
        this.interval = System.ToInt32(roundedInterval)
    end

    this.enabled = false
    this.autoReset = true
    this.initializing = false
    this.delayedEnable = false
    this.callback = TimeCallback
end


getAutoReset = function (this)
    return this.autoReset
end

setAutoReset = function (this, value)
    if this:getDesignMode() then
        this.autoReset = value
    elseif this.autoReset ~= value then
        this.autoReset = value
        if this.timer ~= nil then
            UpdateTimer(this)
        end
    end
end

getEnabled = function (this)
    return this.enabled
end

setEnabled = function (this, value)
    if this:getDesignMode() then
        this.delayedEnable = value
        this.enabled = value
    elseif this.initializing then
        this.delayedEnable = value
    elseif this.enabled ~= value then
    if not value then
        if this.timer ~= nil then
            this.cookie = nil
            killTimer(this.timer) --this.timer:Dispose()
            this.timer = nil
        end
        this.enabled = value
    else
        this.enabled = value
        if this.timer == nil then
            if this.disposed then
                System.throw(System.ObjectDisposedException(this:GetType():getName()))
            end

            local i = System.ToInt32(ceil(this.interval))
            this.cookie = System.Object()
            this.timer = setTimer(function() this.callback(this) end, i, this.autoReset and 0 or 1) -- System.Timer(this.callback, this.cookie, i, this.autoReset and i or -1 --[[Timeout.Infinite]])
        else
            UpdateTimer(this)
        end
    end
    end
end

UpdateTimer = function (this)
    local i = System.ToInt32(ceil(this.interval))
    if isTimer(this.timer) then killTimer(this.timer) end
    this.timer = setTimer(function() this.callback(this) end, i, this.autoReset and 0 or 1) -- System.Timer(this.callback, this.cookie, i, this.autoReset and i or -1 --[[Timeout.Infinite]])
    -- this.timer:Change(i, this.autoReset and i or -1 --[[Timeout.Infinite]])
end

getInterval = function (this)
    return this.interval
end

setInterval = function (this, value)
    if value <= 0 then
        System.throw(System.ArgumentException())
    end

    this.interval = value
    if this.timer ~= nil then
        UpdateTimer(this)
    end
end

addElapsed = function (this, value)
    this.onIntervalElapsed = this.onIntervalElapsed + value
end

removeElapsed = function (this, value)
    this.onIntervalElapsed = this.onIntervalElapsed - value
end


setSite = function (this, value)
    System.base(this):setSite(this, value)
    if this:getDesignMode() then
        this.enabled = true
    end
end

getSite = function (this)
    return System.base(this):getSite(this)
end

getSynchronizingObject = function (this)
    return this.synchronizingObject
end

setSynchronizingObject = function (this, value)
    this.synchronizingObject = value
end

BeginInit = function (this)
    System.throw(System.NotImplementedException())
end

Close = function (this)
    System.throw(System.NotImplementedException())
end

Dispose = function (this, disposing)
    this.disposed = true
    System.base(this).Dispose(this, disposing)
end

EndInit = function (this)
    System.throw(System.NotImplementedException())
end

Start = function (this)
    setEnabled(this, true)
end

Stop = function (this)
    setEnabled(this, false)
end

TimeCallback = function(this)
    if not this.autoReset then
        this.enabled = false
    end

    local elapsedEventArgs = SystemTimers.ElapsedEventArgs()
    local intervalElapsed = this.onIntervalElapsed
    if intervalElapsed ~= nil then
        if getSynchronizingObject(this) ~= nil and getSynchronizingObject(this):getInvokeRequired() then
            getSynchronizingObject(this):BeginInvoke(intervalElapsed, ArrayObject(this, elapsedEventArgs))
        else
            intervalElapsed(this, elapsedEventArgs)
        end      
    end
end

System.define("System.Timers.Timer", {
    __inherits__ = function (out, this)
        local base = System.ComponentModel.Component
        this.__gc = base.__gc
        return {
            base
        }
    end,
    interval = 0,
    enabled = false,
    initializing = false,
    delayedEnable = false,
    autoReset = false,
    disposed = false,
    getAutoReset = getAutoReset,
    setAutoReset = setAutoReset,
    getEnabled = getEnabled,
    setEnabled = setEnabled,
    getInterval = getInterval,
    setInterval = setInterval,
    addElapsed = addElapsed,
    removeElapsed = removeElapsed,
    setSite = setSite,
    getSite = getSite,
    getSynchronizingObject = getSynchronizingObject,
    setSynchronizingObject = setSynchronizingObject,
    BeginInit = BeginInit,
    Close = Close,
    Dispose = Dispose,
    EndInit = EndInit,
    Start = Start,
    Stop = Stop,
    __ctor__ = __ctor__
})