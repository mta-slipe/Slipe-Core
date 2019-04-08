using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.GameWorld;

namespace Slipe.Server.GameWorld
{
    public class World : SharedWorld
    {
        public static new World Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new World();
                }
                return (World)instance;
            }
        }

        #region Constructor
        /// <summary>
        /// Instantiate a new world
        /// </summary>
        public World()
        {

        }
        #endregion

        /// <summary>
        /// Get a specific garage class instance from a garage ID
        /// </summary>
        public new Garage GetGarage(GarageLocation garage)
        {
            return new Garage(garage);
        }

    }
}
