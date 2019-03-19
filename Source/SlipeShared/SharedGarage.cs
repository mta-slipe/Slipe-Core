using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Enums;
using Slipe.MTADefinitions;

namespace Slipe.Shared
{
    /// <summary>
    /// Class wrapping a garage as seen in singleplayer
    /// </summary>
    public class SharedGarage
    {
        protected int _garageID;

        /// <summary>
        /// Create a garage instance from the garage ID
        /// </summary>
        public SharedGarage(GarageEnum garageID)
        {
            _garageID = (int) garageID;
        }

        /// <summary>
        /// Get and set the open state of the garage
        /// </summary>
        public bool Open
        {
            get
            {
                return MTAShared.IsGarageOpen(_garageID);
            }
            set
            {
                MTAShared.SetGarageOpen(_garageID, value);
            }
        }
    }
}
