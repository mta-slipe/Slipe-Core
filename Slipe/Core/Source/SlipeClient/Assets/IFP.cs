using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Assets
{
    public class Ifp : Asset
    {
        private MtaElement ifp;

        public Ifp(string filepath): base(filepath)
        {

        }

        /// <summary>
        /// Loads the IFP file into the animation block
        /// </summary>
        /// <param name="customBlockName"></param>
        public void Load(string customBlockName)
        {
            this.ifp = MtaClient.EngineLoadIFP(this.filepath, customBlockName);
        }
    }
}
