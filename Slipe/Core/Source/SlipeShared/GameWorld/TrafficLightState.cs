using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.GameWorld
{
    /// <summary>
    /// Represents the different states of traffic lights in the world
    /// </summary>
    public enum TrafficLightState
    {
        NSGreen,
        NSYellow,
        AllRed,
        EWGreen,
        EWYellow,
        AllGreen,
        AllYellow,
        NSYellowEWGreen,
        EWYellowNSGreen,
        Disabled,
        Auto
    }
}
