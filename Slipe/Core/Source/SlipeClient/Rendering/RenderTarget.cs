using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Client.Dx;

namespace Slipe.Client.Rendering
{
    /// <summary>
    /// A special type of texture that can be drawn on with the dx functions
    /// </summary>
    public class RenderTarget : Texture
    {
        public RenderTarget(Vector2 dimensions, bool withAlpha = false) : base()
        {
            materialElement = MtaClient.DxCreateRenderTarget((int)dimensions.X, (int)dimensions.Y, withAlpha);
        }
    }
}
