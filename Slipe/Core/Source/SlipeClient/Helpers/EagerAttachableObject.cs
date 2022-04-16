﻿using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using SlipeLua.Client.Game;

namespace SlipeLua.Client.Helpers
{
    /// <summary>
    /// Abstract class that implements attaching functionality in an eager way (updates on PreRender)
    /// </summary>
    public abstract class EagerAttachableObject : LazyAttachableObject
    {
        protected override void OnAttach()
        {
            GameClient.OnUpdate += Update;
        }

        protected override void OnDetach()
        {
            GameClient.OnUpdate -= Update;
            base.OnDetach();
        }
    }
}
