using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.Shared.Utilities;
using SlipeLua.Client.Helpers;
using SlipeLua.Client.Game;
using SlipeLua.Client.Rendering;
using SlipeLua.Client.Game.Events;
using SlipeLua.Client.Elements;

namespace SlipeLua.Client.Dx
{
    /// <summary>
    /// Class representing drawable objects
    /// </summary>
    public abstract class Dx2DObject : LazyAttachableObject
    {
        /// <summary>
        /// The color that is used to draw this object
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// The start or center position of the object
        /// </summary>
        private Vector2 pos;
        public Vector2 Position
        {
            get
            {
                Update();
                return pos;
            }
            set
            {
                pos = value;
            }
        }

        /// <summary>
        /// Boolean indicating whether this object is drawn before or after GUI's are drawn
        /// </summary>
        public bool PostGUI { get; set; }

        /// <summary>
        /// Updates this DxObject to the correct position on screen
        /// </summary>
        protected override void Update(RootElement source = null, OnUpdateEventArgs eventArgs = null)
        {
            if(IsAttached)
                pos = Renderer.ScreenFromWorldPosition(ToAttached.Position + Offset.Translation);
        }
    }
}
