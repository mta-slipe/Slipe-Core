local System = System
local SystemComponentModel = System.ComponentModel
local System_Timers = System.Timers
local getRealTime = getRealTime

local getSignalTime, __ctor__

__ctor__ = function (this, low, high)
    System.base(this).__ctor__(this)
    --local fileTime = System.toInt64(bitOr(bitLShift(high, 32), bitAnd(low, 0xffffffff)))
    local res = getRealTime()
    this.signalTime = System.DateTime(res.year + 1900, res.month + 1, res.monthday, res.hour, res.minute, res.second)--System.DateTime.FromFileTime(fileTime)
end

getSignalTime = function (this)
    return this.signalTime
end

System.define("System.Timers.ElapsedEventArgs", {
    __inherits__ = function (out)
        return {
            System.EventArgs
        }
    end,
    signalTime = System.default(System.DateTime),
    getSignalTime = getSignalTime,
    __ctor__ = __ctor__
})