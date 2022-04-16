using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;

namespace SlipeLua.Server.Vehicles
{
    /// <summary>
    /// Represents vehicles with a turret (firetrucks, rhino etc)
    /// </summary>
    public class TurretedVehicle : BaseVehicle
    {
        /// <summary>
        /// Get and set the position of the turret in radians
        /// </summary>
        public Vector2 TurretPosition
        {
            get
            {
                Tuple<float, float> r = MtaShared.GetVehicleTurretPosition(element);
                return new Vector2(r.Item1, r.Item2);
            }
            set
            {
                MtaShared.SetVehicleTurretPosition(element, value.X, value.Y);
            }
        }

        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        public TurretedVehicle(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a plane from a model at a position
        /// </summary>
        public TurretedVehicle(TurretedModel model, Vector3 position)
            : this(model, position, Vector3.Zero) { }

        /// <summary>
        /// Create a plane using all createVehicle arguments
        /// </summary>
        public TurretedVehicle(TurretedModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
            : base(model, position, rotation, numberplate, variant1, variant2) { }

        #endregion

        public static explicit operator TurretedVehicle(Vehicle vehicle)
        {
            if (VehicleModel.FromId(vehicle.Model) is TurretedModel)
                return new TurretedVehicle(vehicle.MTAElement);

            throw (new InvalidCastException("The vehicle is not a turreted vehicle"));
        }
    }

    /// <summary>
    /// Represents vehicle models that have a turret
    /// </summary>
    public class TurretedModel : VehicleModel
    {
        internal TurretedModel(int id) : base(id) { }
    }
}
