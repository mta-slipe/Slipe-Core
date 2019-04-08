using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Client.Helpers
{
    /// <summary>
    /// Abstract class that implements attaching functionality in an eager way (updates on PreRender)
    /// </summary>
    public abstract class EagerAttachableObject : LazyAttachableObject
    {
        protected override void OnAttach()
        {
            GameClient.Client.Renderer.OnPreRender += Update;
        }

        protected override void OnDetach()
        {
            GameClient.Client.Renderer.OnPreRender -= Update;
            base.OnDetach();
        }
    }
}
