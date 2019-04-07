using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using System.ComponentModel;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Represents boats
    /// </summary>
    public class Boat : Vehicle
    {
        #region Constructors
        /// <summary>
        /// Create a plane from a model at a position
        /// </summary>
        public Boat(BoatModel model, Vector3 position) : base(model, position)
        {

        }

        /// <summary>
        /// Create a plane using all createVehicle arguments
        /// </summary>
        public Boat(BoatModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1) : base(model, position, rotation, numberplate, variant1, variant2)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Boat(MTAElement element) : base(element)
        {

        }

        #endregion
    }

    /// <summary>
    /// Represents models that represent boats
    /// </summary>
    public class BoatModel : BaseVehicleModel
    {
        public static BoatModel Coastguard { get { return new BoatModel(472); } }
        public static BoatModel Dinghy { get { return new BoatModel(473); } }
        public static BoatModel Jetmax { get { return new BoatModel(493); } }
        public static BoatModel Launch { get { return new BoatModel(595); } }
        public static BoatModel Marquis { get { return new BoatModel(484); } }
        public static BoatModel Predator { get { return new BoatModel(430); } }
        public static BoatModel Reefer { get { return new BoatModel(453); } }
        public static BoatModel Speeder { get { return new BoatModel(452); } }
        public static BoatModel Squalo { get { return new BoatModel(446); } }
        public static BoatModel Tropic { get { return new BoatModel(454); } }
        protected BoatModel(int id) : base(id) { }
    }
}
