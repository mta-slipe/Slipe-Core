using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Server.Vehicles
{
    /// <summary>
    /// A train
    /// </summary>
    public class Train : Vehicle
    {
        #region Properties
        /// <summary>
        /// Get and set the direction of the train
        /// </summary>
        public bool DirectionClockwise
        {
            get
            {
                return MTAShared.GetTrainDirection(element);
            }
            set
            {
                MTAShared.SetTrainDirection(element, value);
            }
        }

        /// <summary>
        /// Get and set the position of the train on its current track (0 - 18107 a complete way round)
        /// </summary>
        public float TrackPosition
        {
            get
            {
                return MTAShared.GetTrainPosition(element);
            }
            set
            {
                MTAShared.SetTrainPosition(element, value);
            }
        }

        /// <summary>
        /// Get and set the speed of the train
        /// </summary>
        public float Speed
        {
            get
            {
                return MTAShared.GetTrainSpeed(element);
            }
            set
            {
                MTAShared.SetTrainSpeed(element, value);
            }
        }

        /// <summary>
        /// Get and set if this train is derailable
        /// </summary>
        public bool Derailable
        {
            get
            {
                return MTAShared.IsTrainDerailable(element);
            }
            set
            {
                MTAShared.SetTrainDerailable(element, value);
            }
        }

        /// <summary>
        /// Get and set if this train is derailed
        /// </summary>
        public bool Derailed
        {
            get
            {
                return MTAShared.IsTrainDerailed(element);
            }
            set
            {
                MTAShared.SetTrainDerailable(element, value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a train from a model at a position
        /// </summary>
        public Train(TrainModel model, Vector3 position) : base(model, position)
        {

        }


        /// <summary>
        /// Create a train from an MTA vehicle element 
        /// </summary>
        public Train(MTAElement element) : base(element)
        {

        }

        #endregion
    }

    /// <summary>
    /// Represents models that are trains
    /// </summary>
    public class TrainModel : BaseVehicleModel
    {
        public static TrainModel FreightEngine { get { return new TrainModel(537); } }
        public static TrainModel BoxFreight { get { return new TrainModel(590); } }
        public static TrainModel FlatFreight { get { return new TrainModel(569); } }
        public static TrainModel BrownStreakEngine { get { return new TrainModel(538); } }
        public static TrainModel BrownStreakCarriage { get { return new TrainModel(570); } }
        public static TrainModel Trolly { get { return new TrainModel(449); } }
        protected TrainModel(int id) : base(id) { }
    }
}
