local System = System

local Empty, EventArgs, static

static = function (this)
    Empty = EventArgs()
    this.Empty = Empty
end

EventArgs = {
    static = static,
    __metadata__ = function (out)
        return {
            fields = {
            { "Empty", 0xE, EventArgs }
            }
        }
    end
}

System.define("System.EventArgs", EventArgs)