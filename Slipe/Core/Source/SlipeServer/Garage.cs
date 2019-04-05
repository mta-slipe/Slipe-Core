using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.World;

namespace Slipe.Server
{
    /// <summary>
    /// Class wrapping a garage as seen in singleplayer
    /// </summary>
    public class Garage : SharedGarage
    {
        public Garage(GarageLocation garage) : base (garage) { }
    }
}
