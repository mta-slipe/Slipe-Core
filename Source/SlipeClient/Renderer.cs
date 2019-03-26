using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using System.Numerics;
using Slipe.MTADefinitions;

namespace Slipe.Client
{
    /// <summary>
    /// Singleton responsible for rendering
    /// </summary>
    public class Renderer
    {
        protected static Renderer instance;

        public static Renderer Instance
        {
            get
            {
                return instance ?? new Renderer();
            }
        }

        /// <summary>
        /// Returns the size of the screen as a Vector2
        /// </summary>
        public Vector2 ScreenSize
        {
            get
            {
                Tuple<float, float> size = MTAClient.GuiGetScreenSize();
                return new Vector2(size.Item1, size.Item2);
            }
        }

        /// <summary>
        /// Creates an instance of the renderer
        /// </summary>
        public Renderer()
        {
            instance = this;

            Element.OnRootEvent += HandleRootEvent;
            Element.Root.AddEventHandler("onClientRender");
            Element.Root.AddEventHandler("onClientPreRender");

        }

        /// <summary>
        /// Draw a line between two points on screen
        /// </summary>
        public bool DrawLine(Vector2 start, Vector2 end, Color color, float width = 1.0f, bool postGui = false)
        {
            return MTAClient.DxDrawLine((int)start.X, (int)start.Y, (int)end.X, (int)end.Y, color.Hex, width, postGui);
        }

        /// <summary>
        /// Handles player events on the root element
        /// </summary>
        public void HandleRootEvent(string eventName, Slipe.MTADefinitions.MTAElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            switch (eventName)
            {
                case "onClientRender":
                    OnRender?.Invoke();
                    break;
                case "onClientPreRender":
                    OnPreRender?.Invoke();
                    break;
            }
        }

        public delegate void OnRenderHandler();
        public event OnRenderHandler OnRender;
        public delegate void OnPreRenderHandler();
        public event OnPreRenderHandler OnPreRender;
    }
}
