using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client
{
    public class Engine
    {
        protected static Engine instance;

        public static Engine Instance
        {
            get
            {
                return instance ?? new Engine();
            }
        }

        public int GetModelIDFromName(string name)
        {
            return MTAClient.EngineGetModelIDFromName(name);
        }

        public string GetModelNameFromId(int id)
        {
            return MTAClient.EngineGetModelNameFromID(id);
        }

        public float GetModelLODDistance(int model)
        {
            return MTAClient.EngineGetModelLODDistance(model);
        }

        public bool SetModelLODDistance(int model, float distance)
        {
            return MTAClient.EngineSetModelLODDistance(model, distance);
        }

        public string[] GetModelTextureNames(int model)
        {
            dynamic table = MTAClient.EngineGetModelTextureNames(model.ToString());

            return MTAShared.GetArrayFromTable<string>(table, "System.String");
        }

        public string[] GetModelTextureNames(string model)
        {
            dynamic table = MTAClient.EngineGetModelTextureNames(model);

            return MTAShared.GetArrayFromTable<string>(table, "System.String");
        }

        public string[] GetVisibleTextureNames(string nameFilter = null, string modelId = null)
        {
            dynamic table = MTAClient.EngineGetVisibleTextureNames(nameFilter, modelId);
            return MTAShared.GetArrayFromTable<string>(table, "System.String");
        }

        public bool SetAsynchronousLoading(bool value, bool forced = false)
        {
            return MTAClient.EngineSetAsynchronousLoading(value, forced);
        }

        public bool ReplaceAnimation(Ped ped, string internalBlock, string internalAnim, string customBlock, string customAnim)
        {
            return MTAClient.EngineReplaceAnimation(ped.MTAElement, internalBlock, internalAnim, customBlock, customAnim);
        }

    }
}
