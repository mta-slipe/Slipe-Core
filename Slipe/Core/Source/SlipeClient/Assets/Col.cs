using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Assets
{
    /// <summary>
    /// A single .col file
    /// </summary>
    public class COL: Asset
    {
        private MTAElement col;

        public COL(string filepath): base(filepath)
        {

        }

        /// <summary>
        /// Load the col file into memory
        /// </summary>
        public void Load()
        {
            this.col = MTAClient.EngineLoadCOL(this.filepath);
        }

        /// <summary>
        /// Applies the collision in the game
        /// </summary>
        /// <param name="model"></param>
        public void Apply(int model)
        {
            if (this.col == null)
            {
                throw new Exception(string.Format("COL file {0} has not yet been loaded", this.filepath));
            }

            MTAClient.EngineReplaceCOL(this.col, model);
        }
    }
}
