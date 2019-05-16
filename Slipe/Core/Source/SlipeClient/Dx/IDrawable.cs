using Slipe.Client.Elements;
using Slipe.Client.Rendering.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Interface for drawable objects on render
    /// </summary>
    public interface IDrawable
    {
        bool Draw(RootElement source, OnRenderEventArgs eventArgs);
    }
}
