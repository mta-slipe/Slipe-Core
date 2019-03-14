local System = System
local SystemComponentModel = System.ComponentModel
local System_Timers = System.Timers
local getRealTime = getRealTime

local getSignalTime, __ctor__

__ctor__ = function (this, low, high)
    System.base(this).__ctor__(this)
    --local fileTime = System.toInt64(bitOr(bitLShift(high, 32), bitAnd(low, 0xffffffff)))
    this.signalTime = System.DateTime(getRealTime().timestamp * 10000 * 1000)--System.DateTime.FromFileTime(fileTime)
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