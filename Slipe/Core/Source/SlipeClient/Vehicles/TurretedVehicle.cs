using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Represents vehicles with a turret (firetrucks, rhino etc)
    /// </summary>
    public class TurretedVehicle : Vehicle
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

        /// <summary>
        /// Create a vehicle from a model at a position
        /// </summary>
        public TurretedVehicle(TurretedModel model, Vector3 position) : base(model, position)
        {

        }

        /// <summary>
        /// Create a vehicle model using all createVehicle arguments
        /// </summary>
        public TurretedVehicle(TurretedModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1) : base(model, position, rotation, numberplate, variant1, variant2)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public TurretedVehicle(MtaElement element) : base(element)
        {

        }
    }

    /// <summary>
    /// Represents vehicle models that have a turret
    /// </summary>
    public class TurretedModel : BaseVehicleModel
    {
        public static TurretedModel Rhino { get { return new TurretedModel(432); } }
        public static TurretedModel Swat { get { return new TurretedModel(601); } }
        public static TurretedModel Firetruck { get { return new TurretedModel(407); } }
        protected TurretedModel(int id) : base(id) { }
    }
}
