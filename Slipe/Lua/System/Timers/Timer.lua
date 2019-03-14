local System = System
local SystemTimers = System.Timers

local ceil = math.ceil

local new = function (cls, ...)
    local this = setmetatable({}, cls)
    return this, cls.__ctor__(this, ...)
end

local Timer = {}

Timer.__ctor__ = function(this, interval)
    if interval then
        if interval <= 0 then
            System.throw(System.ArgumentException())
        end
        local roundedInterval = ceil(interval)
        if roundedInterval > 2147483647 --[[Int32.MaxValue]] or roundedInterval <= 0 then
            System.throw(System.ArgumentException())
        end
        this.interval = System.ToInt32(roundedInterval)
    else
        this.interval = 100
    end
    this.enabled = false
    this.autoReset = true
    this.initializing = false
    this.delayedEnable = false
    this.callback = nil
end

Timer.getAutoReset = function (this)
    return this.autoReset
end

Timer.setAutoReset = function (this, value)
    this.autoReset = value
end

Timer.getEnabled = function (this)
    return this.enabled
end

Timer.setEnabled = function (this, value)
    this.enabled = value
end

System.define("System.Timers.Timer", Timer)