using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using System.ComponentModel;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Represents helicopter vehicles
    /// </summary>
    public class Helicopter : Vehicle
    {
        /// <summary>
        /// Get and set the rotor speed (between 0 and 0.2)
        /// </summary>
        public float RotorSpeed
        {
            get
            {
                return MtaClient.GetHelicopterRotorSpeed(element);
            }
            set
            {
                MtaClient.SetHelicopterRotorSpeed(element, value);
            }
        }

        /// <summary>
        /// Get and set if the collisions of the blades are enabled
        /// </summary>
        public bool BladeCollisionsEnabeled
        {
            get
            {
                return MtaClient.GetHeliBladeCollisionsEnabled(element);
            }
            set
            {
                MtaClient.SetHeliBladeCollisionsEnabled(element, value);
            }
        }

        #region Constructors
        /// <summary>
        /// Create a plane from a model at a position
        /// </summary>
        public Helicopter(HelicopterModel model, Vector3 position) : base(model, position)
        {

        }

        /// <summary>
        /// Create a plane using all createVehicle arguments
        /// </summary>
        public Helicopter(HelicopterModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1) : base(model, position, rotation, numberplate, variant1, variant2)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Helicopter(MtaElement element) : base(element)
        {

        }

        #endregion
    }

    /// <summary>
    /// Models that represent helicopters
    /// </summary>
    public class HelicopterModel : BaseVehicleModel
    {
        public static HelicopterModel Cargobob { get { return new HelicopterModel(548); } }
        public static HelicopterModel Hunter { get { return new HelicopterModel(425); } }
        public static HelicopterModel Leviathan { get { return new HelicopterModel(417); } }
        public static HelicopterModel Maverick { get { return new HelicopterModel(487); } }
        public static HelicopterModel Newschopper { get { return new HelicopterModel(488); } }
        public static HelicopterModel PoliceMaverick { get { return new HelicopterModel(497); } }
        public static HelicopterModel Raindance { get { return new HelicopterModel(563); } }
        public static HelicopterModel Seasparrow { get { return new HelicopterModel(447); } }
        public static HelicopterModel Sparrow { get { return new HelicopterModel(469); } }
        public static HelicopterModel RcGoblin { get { return new HelicopterModel(501); } }
        public static HelicopterModel RcRaider { get { return new HelicopterModel(465); } }
        protected HelicopterModel(int id) : base(id) { }
    }
}
