using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Planes as a special type of vehicle
    /// </summary>
    public class Plane : BaseVehicle
    {
        /// <summary>
        /// Get and set if the Plane's landing gear is down or not
        /// </summary>
        public bool LandingGearDown
        {
            get
            {
                return MTAShared.GetVehicleLandingGearDown(element);
            }
            set
            {
                MTAShared.SetVehicleLandingGearDown(element, value);
            }
        }

        #region Constructors
        /// <summary>
        /// Create a plane from a model at a position
        /// </summary>
        public Plane(PlaneModel model, Vector3 position) : base(model, position)
        {

        }

        /// <summary>
        /// Create a plane using all createVehicle arguments
        /// </summary>
        public Plane(PlaneModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1) : base(model, position, rotation, numberplate, variant1, variant2)
        {
        }

        /// <summary>
        /// Create a plane from an MTA vehicle element 
        /// </summary>
        public Plane(MTAElement element) : base(element)
        {

        }

        #endregion
    }

    /// <summary>
    /// Represents models that represent planes
    /// </summary>
    public class PlaneModel : BaseVehicleModel
    {
        public static PlaneModel Andromada { get { return new PlaneModel(592); } }
        public static PlaneModel At400 { get { return new PlaneModel(577); } }
        public static PlaneModel Beagle { get { return new PlaneModel(511); } }
        public static PlaneModel Cropduster { get { return new PlaneModel(512); } }
        public static PlaneModel Dodo { get { return new PlaneModel(593); } }
        public static PlaneModel Hydra { get { return new PlaneModel(520); } }
        public static PlaneModel Nevada { get { return new PlaneModel(553); } }
        public static PlaneModel Rustler { get { return new PlaneModel(476); } }
        public static PlaneModel Shamal { get { return new PlaneModel(519); } }
        public static PlaneModel Skimmer { get { return new PlaneModel(460); } }
        public static PlaneModel Stuntplane { get { return new PlaneModel(513); } }
        public static PlaneModel RcBaron { get { return new PlaneModel(464); } }
        protected PlaneModel(int id) : base(id) { }
    }
}
