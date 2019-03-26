using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.Shared.Enums;

namespace Slipe.Server
{
    /// <summary>
    /// Class wrapping a garage as seen in singleplayer
    /// </summary>
    public class Garage : SharedGarage
    {
        public Garage(GarageEnum garage) : base (garage) { }
    }
}
