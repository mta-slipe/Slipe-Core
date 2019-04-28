using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Slipe.Client.GameClient;

namespace Slipe.Client.Helpers
{
    /// <summary>
    /// Abstract class that implements attaching functionality in an eager way (updates on PreRender)
    /// </summary>
    public abstract class EagerAttachableObject : LazyAttachableObject
    {
        protected override void OnAttach()
        {
            Process.OnUpdate += Update;
        }

        protected override void OnDetach()
        {
            Process.OnUpdate -= Update;
            base.OnDetach();
        }
    }
}
