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
            Element.Root.AddEventHandler("onClientHUDRender");
        }

        /// <summary>
        /// Get the World position from a screen position
        /// </summary>
        public Vector3 WorldFromScreenPosition(Vector2 screenPosition, float depth)
        {
            Tuple<float, float, float> result = MTAClient.GetWorldFromScreenPosition(screenPosition.X, screenPosition.Y, depth);
            return new Vector3(result.Item1, result.Item2, result.Item3);
        }

        /// <summary>
        /// Get the screen position from a world position
        /// </summary>
        public Vector2 ScreenFromWorldPosition(Vector3 worldPosition, float edgeTolerance = 0.0f, bool relative = true)
        {
            Tuple<float, float> result = MTAClient.GetScreenFromWorldPosition(worldPosition.X, worldPosition.Y, worldPosition.Z, edgeTolerance, relative);
            return new Vector2(result.Item1, result.Item2);
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
                case "OnClientHUDRender":
                    OnHudRender?.Invoke();
                    break;
            }
        }

        public delegate void OnRenderHandler();
        public event OnRenderHandler OnRender;
        public delegate void OnPreRenderHandler();
        public event OnPreRenderHandler OnPreRender;
        public delegate void OnHudRenderHandler();
        public event OnHudRenderHandler OnHudRender;
    }
}
