using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.GameWorld;

namespace Slipe.Server.GameWorld
{
    /// <summary>
    /// Class wrapping a garage as seen in singleplayer
    /// </summary>
    public class Garage : SharedGarage
    {
        public Garage(GarageLocation garage) : base(garage) { }
    }
}
