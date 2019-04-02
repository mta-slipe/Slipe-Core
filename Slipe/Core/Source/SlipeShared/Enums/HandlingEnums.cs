using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Enums
{
    /// <summary>
    /// Represents different vehicle drive types
    /// </summary>
    public enum DriveType
    {
        rwd,
        fwd,
        awd
    }

    /// <summary>
    /// Represents dfiferent engine types
    /// </summary>
    public enum EngineType
    {
        petrol,
        diesel,
        electric
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
