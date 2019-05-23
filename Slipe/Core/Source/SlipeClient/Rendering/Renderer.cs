using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using Slipe.Client.Elements;
using Slipe.Client.Rendering.Events;

namespace Slipe.Client.Rendering
{
    /// <summary>
    /// Singleton responsible for rendering
    /// </summary>
    public static class Renderer
    {
        private static Status status;

        #region Properties

        /// <summary>
        /// Get and set the limit at which the game is rendered
        /// </summary>
        public static int FpsLimit
        {
            get
            {
                return MtaShared.GetFPSLimit();
            }
            set
            {
                MtaShared.SetFPSLimit(value);
            }
        }

        private static Vector2 screenSize;
        /// <summary>
        /// Returns the size of the screen as a Vector2
        /// </summary>
        public static Vector2 ScreenSize
        {
            get
            {
                if (screenSize == Vector2.Zero)
                {
                    Tuple<float, float> size = MtaClient.GuiGetScreenSize();
                    screenSize = new Vector2(size.Item1, size.Item2);
                }
                return screenSize;
            }
        }

        /// <summary>
        /// Get and set the blendmode of the renderer
        /// </summary>
        public static BlendMode BlendMode
        {
            get
            {
                return (BlendMode)Enum.Parse(typeof(BlendMode), MtaClient.DxGetBlendMode(), true);
            }
            set
            {
                MtaClient.DxSetBlendMode(value.ToString());
            }
        }

        /// <summary>
        /// This function is used for testing scripts written using guiCreateFont, dxCreateFont, dxCreateShader and dxCreateRenderTarget.
        /// </summary>
        public static TestMode TestMode
        {
            set
            {
                MtaClient.DxSetTestMode(value.ToString());
            }
        }

        /// <summary>
        /// Gets information about various internal datum
        /// </summary>
        public static Status Status
        {
            get
            {
                if (status == null)
                    status = new Status();
                return status;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// This function changes the drawing destination for the dx functions.
        /// </summary>
        public static bool SetRenderTarget(RenderTarget target, bool clear = false)
        {
            return MtaClient.DxSetRenderTarget(target.MaterialElement, clear);
        }

        /// <summary>
        /// Reverts the current rendertarget to the screen
        /// </summary>
        /// <returns></returns>
        public static bool RevertRenderTargetToScreen()
        {
            return MtaClient.DxSetRenderTarget();
        }

        /// <summary>
        /// This function allows for the positioning of dxDraw calls to be automatically adjusted according to the client's aspect ratio setting. This lasts for a single execution of an event handler for one of the following events: onClientRender, onClientPreRender and onClientHUDRender. So the function has to be called every frame, just like dxDraws.
        /// </summary>
        public static bool SetAspectRatioAdjustmentEnabled(bool enabled, float sourceRatio = 4 / 3)
        {
            return MtaClient.DxSetAspectRatioAdjustmentEnabled(enabled, sourceRatio);
        }

        /// <summary>
        /// Get the World position from a screen position
        /// </summary>
        public static Vector3 WorldFromScreenPosition(Vector2 screenPosition, float depth)
        {
            Tuple<float, float, float> result = MtaClient.GetWorldFromScreenPosition(screenPosition.X, screenPosition.Y, depth);
            return new Vector3(result.Item1, result.Item2, result.Item3);
        }

        /// <summary>
        /// Get the screen position from a world position
        /// </summary>
        public static Vector2 ScreenFromWorldPosition(Vector3 worldPosition, float edgeTolerance = 0.0f, bool relative = true)
        {
            Tuple<float, float> result = MtaClient.GetScreenFromWorldPosition(worldPosition.X, worldPosition.Y, worldPosition.Z, edgeTolerance, relative);
            return new Vector2(result.Item1, result.Item2);
        }

        #endregion

        #region Events

#pragma warning disable 67

        public delegate void OnRenderHandler(RootElement source, OnRenderEventArgs eventArgs);
        public static event OnRenderHandler OnRender;

        public delegate void OnHudRenderHandler(RootElement source, OnHudRenderEventArgs eventArgs);
        public static event OnHudRenderHandler OnHudRender;

#pragma warning enable 67

        #endregion
    }
}
