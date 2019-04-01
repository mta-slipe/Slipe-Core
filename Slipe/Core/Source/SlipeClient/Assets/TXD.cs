using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Assets
{
    public class TXD: Asset
    {
        private MTAElement txd;

        public TXD(string filepath): base(filepath)
        {

        }

        /// <summary>
        /// Loads the TXD file into memory
        /// </summary>
        /// <param name="filteringEnabled"></param>
        public void Load(bool filteringEnabled = true)
        {
            this.txd = MTAClient.EngineLoadTXD(this.filepath, filteringEnabled);
        }

        /// <summary>
        /// Applies the TXD to the game
        /// </summary>
        /// <param name="model"></param>
        public void Apply(int model)
        {
            if (this.txd == null)
            {
                throw new Exception(string.Format("TXD file {0} has not yet been loaded", this.filepath));
            }

            MTAClient.EngineImportTXD(this.txd, model);
        }
    }
}
