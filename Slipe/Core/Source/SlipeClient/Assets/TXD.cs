using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Assets
{
    public class Txd : Asset
    {
        private MtaElement txd;

        public Txd(string filepath): base(filepath)
        {

        }

        /// <summary>
        /// Loads the TXD file into memory
        /// </summary>
        /// <param name="filteringEnabled"></param>
        public void Load(bool filteringEnabled = true)
        {
            if (this.txd != null)
            {
                return;
            }
            this.txd = MtaClient.EngineLoadTXD(this.filepath, filteringEnabled);
        }

        /// <summary>
        /// Applies the TXD to the game
        /// </summary>
        /// <param name="model"></param>
        public void ApplyTo(int model)
        {
            if (this.txd == null)
            {
                throw new Exception(string.Format("TXD file {0} has not yet been loaded", this.filepath));
            }

            MtaClient.EngineImportTXD(this.txd, model);
        }
    }
}
