using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Shared.Vehicles
{
    /// <summary>
    /// Class representation of different vehicle models
    /// </summary>
    public class SharedVehicleModel
    {
        #region Properties

        protected int id;
        /// <summary>
        /// The ID of this model
        /// </summary>
        public int ID
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Get the string representation of the name of this model
        /// </summary>
        public string Name
        {
            get
            {
                return MtaShared.GetVehicleNameFromModel(id);
            }
        }

        /// <summary>
        /// Get the original handling of this model
        /// </summary>
        public Handling OriginalHandling
        {
            get
            {
                Dictionary<string, dynamic> d = MtaShared.GetDictionaryFromTable(MtaShared.GetOriginalHandling(id), "System.String", "dynamic");
                return new Handling(d);
            }
        }

        #endregion

        protected SharedVehicleModel(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Get a vehicle model from the model name as a string
        /// </summary>
        public static SharedVehicleModel FromName(string name)
        {
            int id = MtaShared.GetVehicleModelFromName(name);
            return new SharedVehicleModel(id);
        }

    }
}
