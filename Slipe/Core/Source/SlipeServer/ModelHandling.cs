using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.MTADefinitions;
using Slipe.Shared.Enums;

namespace Slipe.Server
{
    public class ModelHandling : VehicleHandling
    {
        protected VehicleModel model;

        /// <summary>
        /// Builds vehicle handling from a vehicle model
        /// </summary>
        public ModelHandling(VehicleModel targetModel) : base()
        {
            model = targetModel;
        }

        protected override void UpdateFromGame()
        {
            BuildFromTable(MTAShared.GetDictionaryFromTable(MTAServer.GetModelHandling((int) model), "System.String", "System.Dynamic"));
        }

        protected override void UpdateToGame(string key, dynamic value)
        {
            MTAServer.SetModelHandling((int)model, key, value);
        }
    }
}
