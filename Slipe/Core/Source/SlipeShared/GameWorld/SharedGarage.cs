using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Shared.GameWorld
{
    /// <summary>
    /// Class wrapping a garage as seen in singleplayer
    /// </summary>
    public class SharedGarage
    {
        protected int _garageID;

        /// <summary>
        /// Get and set the open state of the garage
        /// </summary>
        public bool Open
        {
            get
            {
                return MtaShared.IsGarageOpen(_garageID);
            }
            set
            {
                MtaShared.SetGarageOpen(_garageID, value);
            }
        }

        /// <summary>
        /// Create a garage instance from the garage ID
        /// </summary>
        public SharedGarage(GarageLocation garageID)
        {
            _garageID = (int)garageID;
        }


    }
}
