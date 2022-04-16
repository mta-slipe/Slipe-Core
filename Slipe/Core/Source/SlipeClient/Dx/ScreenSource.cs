using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Client.Dx
{
    /// <summary>
    /// A special type of texture that contains the screen as rendered by GTA
    /// </summary>
    public class ScreenSource : Texture
    {
        /// <summary>
        /// Create a new screen source
        /// </summary>
        public ScreenSource(Vector2 dimensions)
        {
            materialElement = MtaClient.DxCreateScreenSource((int)dimensions.X, (int)dimensions.Y);
        }

        /// <summary>
        /// This function updates the contents of this screen source texture with the screen output from GTA
        /// </summary>
        public bool Update(bool resampleNow = false)
        {
            return MtaClient.DxUpdateScreenSource(materialElement, resampleNow);
        }
    }
}
