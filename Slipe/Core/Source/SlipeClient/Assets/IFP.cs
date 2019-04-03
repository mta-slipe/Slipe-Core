using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Assets
{
    public class IFP: Asset
    {
        private MTAElement ifp;

        public IFP(string filepath): base(filepath)
        {

        }

        /// <summary>
        /// Loads the IFP file into the animation block
        /// </summary>
        /// <param name="filteringEnabled"></param>
        public void Load(string customBlockName)
        {
            this.ifp = MTAClient.EngineLoadIFP(this.filepath, customBlockName);
        }
    }
}
