using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Shared.Vehicles
{
    /// <summary>
    /// Class representation of different vehicle models
    /// </summary>
    public abstract class SharedVehicleModel
    {
        #region Fields
        protected static int[] boatModels = { 472, 473, 493, 595, 484, 430, 453, 452, 446, 454 };
        protected static int[] planeModels = { 592, 577, 511, 512, 593, 520, 553, 476, 519, 460, 513, 464 };
        protected static int[] helicopterModels = { 548, 425, 417, 487, 488, 497, 563, 447, 469, 501, 465 };
        protected static int[] trailerModels = { 606, 607, 608, 610, 611, 584, 435, 450, 591 };
        protected static int[] trainModels = { 537, 590, 569, 538, 570, 449 };
        protected static int[] turretedModels = { 432, 601, 407 };
        protected static int[] taxiModels = { 438, 420 };
        #endregion

        #region Properties

        /// <summary>
        /// The ID of this model
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Get the string representation of the name of this model
        /// </summary>
        public string Name
        {
            get
            {
                return MtaShared.GetVehicleNameFromModel(Id);
            }
        }

        /// <summary>
        /// Get the original handling of this model
        /// </summary>
        public Handling OriginalHandling
        {
            get
            {
                Dictionary<string, dynamic> d = MtaShared.GetDictionaryFromTable(MtaShared.GetOriginalHandling(Id), "System.String", "dynamic");
                return new Handling(d);
            }
        }

        #endregion

        protected SharedVehicleModel(int id)
        {
            this.Id = id;
        }

    }
}
