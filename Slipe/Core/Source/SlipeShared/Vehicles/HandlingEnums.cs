using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Vehicles
{
    /// <summary>
    /// Represents different vehicle drive types
    /// </summary>
    public enum DriveType
    {
        Rwd,
        Fwd,
        Awd
    }

    /// <summary>
    /// Represents dfiferent engine types
    /// </summary>
    public enum EngineType
    {
        Petrol,
        Diesel,
        Electric
    }

    /// <summary>
    /// Represents lights used in Vehicle Handling
    /// </summary>
    public enum VehicleLightType
    {
        Long,
        Small,
        Big,
        Tall
    }
}
