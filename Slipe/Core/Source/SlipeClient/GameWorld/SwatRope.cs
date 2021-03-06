﻿using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;

namespace Slipe.Client.GameWorld
{
    /// <summary>
    /// Represents a SWAT rope that can be created
    /// </summary>
    public class SwatRope
    {
        public SwatRope(Vector3 position, int duration)
        {
            MtaClient.CreateSWATRope(position.X, position.Y, position.Z, duration);
        }
    }
}
