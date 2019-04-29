using Slipe.Client.Peds;
using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.GameClient
{
    public class Engine
    {
        protected static Engine instance;

        public static Engine Instance
        {
            get
            {
                instance = instance ?? new Engine();
                return instance;
            }
        }

        public int GetModelIDFromName(string name)
        {
            return MtaClient.EngineGetModelIDFromName(name);
        }

        public string GetModelNameFromId(int id)
        {
            return MtaClient.EngineGetModelNameFromID(id);
        }

        public float GetModelLODDistance(int model)
        {
            return MtaClient.EngineGetModelLODDistance(model);
        }

        public bool SetModelLODDistance(int model, float distance)
        {
            return MtaClient.EngineSetModelLODDistance(model, distance);
        }

        public string[] GetModelTextureNames(int model)
        {
            dynamic table = MtaClient.EngineGetModelTextureNames(model.ToString());

            return MtaShared.GetArrayFromTable(table, "System.String");
        }

        public string[] GetModelTextureNames(string model)
        {
            dynamic table = MtaClient.EngineGetModelTextureNames(model);

            return MtaShared.GetArrayFromTable(table, "System.String");
        }

        public string[] GetVisibleTextureNames(string nameFilter = null, string modelId = null)
        {
            dynamic table = MtaClient.EngineGetVisibleTextureNames(nameFilter, modelId);
            return MtaShared.GetArrayFromTable(table, "System.String");
        }

        public bool SetAsynchronousLoading(bool value, bool forced = false)
        {
            return MtaClient.EngineSetAsynchronousLoading(value, forced);
        }

        public bool ReplaceAnimation(Ped ped, string internalBlock, string internalAnim, string customBlock, string customAnim)
        {
            return MtaClient.EngineReplaceAnimation(ped.MTAElement, internalBlock, internalAnim, customBlock, customAnim);
        }

    }
}
