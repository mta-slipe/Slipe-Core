using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;

namespace SlipeLua.Client.Vehicles
{
    /// <summary>
    /// A train
    /// </summary>
    public class Train : BaseVehicle
    {
        #region Properties
        /// <summary>
        /// Get and set the direction of the train
        /// </summary>
        public bool DirectionClockwise
        {
            get
            {
                return MtaShared.GetTrainDirection(element);
            }
            set
            {
                MtaShared.SetTrainDirection(element, value);
            }
        }

        /// <summary>
        /// Get and set the position of the train on its current track (0 - 18107 a complete way round)
        /// </summary>
        public float TrackPosition
        {
            get
            {
                return MtaShared.GetTrainPosition(element);
            }
            set
            {
                MtaShared.SetTrainPosition(element, value);
            }
        }

        /// <summary>
        /// Get and set the speed of the train
        /// </summary>
        public float Speed
        {
            get
            {
                return MtaShared.GetTrainSpeed(element);
            }
            set
            {
                MtaShared.SetTrainSpeed(element, value);
            }
        }

        /// <summary>
        /// Get and set if this train is derailable
        /// </summary>
        public bool Derailable
        {
            get
            {
                return MtaShared.IsTrainDerailable(element);
            }
            set
            {
                MtaShared.SetTrainDerailable(element, value);
            }
        }

        /// <summary>
        /// Get and set if this train is derailed
        /// </summary>
        public bool Derailed
        {
            get
            {
                return MtaShared.IsTrainDerailed(element);
            }
            set
            {
                MtaShared.SetTrainDerailed(element, true);
            }
        }

        /// <summary>
        /// Get if this train is the front engine
        /// </summary>
        public bool IsChainEngine
        {
            get
            {
                return MtaClient.IsTrainChainEngine(element);
            }
        }

        #endregion

        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Train(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a plane from a model at a position
        /// </summary>
        public Train(TrainModel model, Vector3 position)
            : this(model, position, Vector3.Zero) { }

        /// <summary>
        /// Create a plane using all createVehicle arguments
        /// </summary>
        public Train(TrainModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
            : base(model, position, rotation, numberplate, variant1, variant2) { }

        #endregion

        public static explicit operator Train(Vehicle vehicle)
        {
            if (VehicleModel.FromId(vehicle.Model) is TrainModel)
                return new Train(vehicle.MTAElement);

            throw (new InvalidCastException("The vehicle is not a train"));
        }
    }

    /// <summary>
    /// Represents models that are trains
    /// </summary>
    public class TrainModel : VehicleModel
    {
        internal TrainModel(int id) : base(id) { }
    }
}
