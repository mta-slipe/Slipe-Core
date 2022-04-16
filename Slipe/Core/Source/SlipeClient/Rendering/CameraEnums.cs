using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Rendering
{
    /// <summary>
    /// Represents different google view effects
    /// </summary>
    public enum GoggleEffects
    {
        Normal,
        NightVision,
        ThermalVision
    }

    /// <summary>
    /// Represents different vehicle camera view modes
    /// </summary>
    public enum CameraViewMode
    {
        Bumper = 0,
        CloseExternal = 1,
        MiddleExternal = 2,
        FarExternal = 3,
        LowExternal = 4,
        Cinematic = 5
    }

    /// <summary>
    /// Represents different camera modes for the player
    /// </summary>
    public enum CameraMode
    {
        Player,
        Vehicle,
        Vehicle_Max
    }
}
