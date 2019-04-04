using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Server.Vehicles
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
                Tuple<float, float> r = MTAShared.GetVehicleTurretPosition(element);
                return new Vector2(r.Item1, r.Item2);
            }
            set
            {
                MTAShared.SetVehicleTurretPosition(element, value.X, value.Y);
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

        /// <summary>
        /// Create a vehicle from an MTA vehicle element 
        /// </summary>
        public TurretedVehicle(MTAElement element) : base(element)
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
