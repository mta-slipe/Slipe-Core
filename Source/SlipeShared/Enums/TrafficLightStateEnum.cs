using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Enums
{
    /// <summary>
    /// Represents the different states of traffic lights in the world
    /// </summary>
    public enum TrafficLightStateEnum
    {
        NSGREEN,
        NSYELLOW,
        ALLRED,
        EWGREEN,
        EWYELLOW,
        ALLGREEN,
        ALLYELLOW,
        NSYELLOWEWGREEN,
        EWYELLOWNSGREEN,
        DISABLED,
        AUTO
    }
}
