using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper.Enums
{
    public enum GoggleEffects
    {
        NORMAL,
        NIGHTVISION,
        THERMALVISION
    }

    public enum CameraViewMode
    {
        BUMPER = 0,
        CLOSEEXTERNAL = 1,
        MIDDLEEXTERNAL = 2,
        FAREXTERNAL = 3,
        LOWEXTERNAL = 4,
        CINEMATIC = 5
    }

    public enum CameraMode
    {
        PLAYER,
        VEHICLE,
        VEHICLE_MAX
    }
}
