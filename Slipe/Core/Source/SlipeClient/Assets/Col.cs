using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Assets
{
    /// <summary>
    /// A single .col file
    /// </summary>
    public class Col : Asset
    {
        private MtaElement col;

        public Col(string filepath): base(filepath)
        {

        }

        /// <summary>
        /// Load the col file into memory
        /// </summary>
        public void Load()
        {
            if (this.col != null)
            {
                return;
            }
            this.col = MtaClient.EngineLoadCOL(this.filepath);
        }

        /// <summary>
        /// Applies the collision in the game
        /// </summary>
        /// <param name="model"></param>
        public void ApplyTo(int model)
        {
            if (this.col == null)
            {
                throw new Exception(string.Format("COL file {0} has not yet been loaded", this.filepath));
            }

            MtaClient.EngineReplaceCOL(this.col, model);
        }

        public static void Restore(int model)
        {
            MtaClient.EngineRestoreCOL(model);
        }
    }
}
