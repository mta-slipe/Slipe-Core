using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Enums
{
    /// <summary>
    /// Represents different google view effects
    /// </summary>
    public enum GoggleEffects
    {
        NORMAL,
        NIGHTVISION,
        THERMALVISION
    }

    /// <summary>
    /// Represents different vehicle camera view modes
    /// </summary>
    public enum CameraViewMode
    {
        BUMPER = 0,
        CLOSEEXTERNAL = 1,
        MIDDLEEXTERNAL = 2,
        FAREXTERNAL = 3,
        LOWEXTERNAL = 4,
        CINEMATIC = 5
    }

    /// <summary>
    /// Represents different camera modes for the player
    /// </summary>
    public enum CameraMode
    {
        PLAYER,
        VEHICLE,
        VEHICLE_MAX
    }
}
