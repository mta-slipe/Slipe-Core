using SlipeLua.Client.Elements;
using SlipeLua.Client.Rendering.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Dx
{
    /// <summary>
    /// Interface for drawable objects on render
    /// </summary>
    public interface IDrawable
    {
        bool Draw(RootElement source, OnRenderEventArgs eventArgs);
    }
}
