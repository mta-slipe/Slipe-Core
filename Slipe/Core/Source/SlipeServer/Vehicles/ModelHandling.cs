using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Vehicles;

namespace SlipeLua.Server.Vehicles
{
    public class ModelHandling : Handling
    {
        protected int model;

        /// <summary>
        /// Builds vehicle handling from a vehicle model
        /// </summary>
        public ModelHandling(int targetModel) : base()
        {
            model = targetModel;
        }

        protected override void UpdateFromGame()
        {
            BuildFromTable(MtaShared.GetDictionaryFromTable(MtaServer.GetModelHandling((int) model), "System.String", "System.Dynamic"));
        }

        protected override void UpdateToGame(string key, dynamic value)
        {
            MtaServer.SetModelHandling(model, key, value);
        }
    }
}
