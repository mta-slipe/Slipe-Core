using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Assets
{
    /// <summary>
    /// A single DFF file
    /// </summary>
    public class Dff : Asset
    {
        private MtaElement dff;

        public Dff(string filepath): base(filepath)
        {

        }

        /// <summary>
        /// Loads the DFF file into memory
        /// </summary>
        public void Load()
        {
            this.dff = MtaClient.EngineLoadDFF(this.filepath);
        }

        /// <summary>
        /// Applies the model to the game
        /// </summary>
        /// <param name="model"></param>
        /// <param name="supportsAlpha"></param>
        public void ApplyTo(int model, bool supportsAlpha = false)
        {
            if (this.dff == null)
            {
                throw new Exception(string.Format("DFF file {0} has not yet been loaded", this.filepath));
            }

            MtaClient.EngineReplaceModel(this.dff, model, supportsAlpha);
        }
    }
}
