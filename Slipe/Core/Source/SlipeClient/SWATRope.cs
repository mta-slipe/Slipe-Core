using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Client
{
    /// <summary>
    /// Represents a SWAT rope that can be created
    /// </summary>
    public class SWATRope
    {
        public SWATRope(Vector3 position, int duration)
        {
            MTAClient.CreateSWATRope(position.X, position.Y, position.Z, duration);
        }
    }
}
