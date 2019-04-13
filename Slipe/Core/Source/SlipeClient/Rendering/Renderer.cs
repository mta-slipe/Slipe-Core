using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using Slipe.Client.Elements;

namespace Slipe.Client.Rendering
{
    /// <summary>
    /// Singleton responsible for rendering
    /// </summary>
    public class Renderer
    {
        protected static Renderer instance;
        private Status status;

        public static Renderer Instance
        {
            get
            {
                return instance ?? new Renderer();
            }
        }

        #region Properties

        /// <summary>
        /// Get and set the limit at which the game is rendered
        /// </summary>
        public int FpsLimit
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

        /// <summary>
        /// Returns the size of the screen as a Vector2
        /// </summary>
        public Vector2 ScreenSize
        {
            get
            {
                Tuple<float, float> size = MtaClient.GuiGetScreenSize();
                return new Vector2(size.Item1, size.Item2);
            }
        }

        /// <summary>
        /// Get and set the blendmode of the renderer
        /// </summary>
        public BlendMode BlendMode
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
        public TestMode TestMode
        {
            set
            {
                MtaClient.DxSetTestMode(value.ToString());
            }
        }

        /// <summary>
        /// Gets information about various internal datum
        /// </summary>
        public Status Status
        {
            get
            {
                if (status == null)
                    status = new Status();
                return status;
            }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Creates an instance of the renderer
        /// </summary>
        public Renderer()
        {
            instance = this;

            RootElement.OnRender += () => { OnRender?.Invoke(); };
            RootElement.OnPreRender += (float timeSlice) => { OnPreRender?.Invoke(timeSlice); };
            RootElement.OnHUDRender += () => { OnHudRender?.Invoke(); };
        }
        #endregion

        #region Methods

        /// <summary>
        /// This function changes the drawing destination for the dx functions.
        /// </summary>
        public bool SetRenderTarget(RenderTarget target, bool clear = false)
        {
            return MtaClient.DxSetRenderTarget(target.MaterialElement, clear);
        }

        /// <summary>
        /// Reverts the current rendertarget to the screen
        /// </summary>
        /// <returns></returns>
        public bool RevertRenderTargetToScreen()
        {
            return MtaClient.DxSetRenderTarget();
        }

        /// <summary>
        /// This function allows for the positioning of dxDraw calls to be automatically adjusted according to the client's aspect ratio setting. This lasts for a single execution of an event handler for one of the following events: onClientRender, onClientPreRender and onClientHUDRender. So the function has to be called every frame, just like dxDraws.
        /// </summary>
        public bool SetAspectRatioAdjustmentEnabled(bool enabled, float sourceRatio = 4 / 3)
        {
            return MtaClient.DxSetAspectRatioAdjustmentEnabled(enabled, sourceRatio);
        }

        /// <summary>
        /// Get the World position from a screen position
        /// </summary>
        public Vector3 WorldFromScreenPosition(Vector2 screenPosition, float depth)
        {
            Tuple<float, float, float> result = MtaClient.GetWorldFromScreenPosition(screenPosition.X, screenPosition.Y, depth);
            return new Vector3(result.Item1, result.Item2, result.Item3);
        }

        /// <summary>
        /// Get the screen position from a world position
        /// </summary>
        public Vector2 ScreenFromWorldPosition(Vector3 worldPosition, float edgeTolerance = 0.0f, bool relative = true)
        {
            Tuple<float, float> result = MtaClient.GetScreenFromWorldPosition(worldPosition.X, worldPosition.Y, worldPosition.Z, edgeTolerance, relative);
            return new Vector2(result.Item1, result.Item2);
        }

        #endregion

        #region Events

        public delegate void OnRenderHandler();
        public event OnRenderHandler OnRender;
        public delegate void OnPreRenderHandler(float timeSlice);
        public event OnPreRenderHandler OnPreRender;
        public delegate void OnHudRenderHandler();
        public event OnHudRenderHandler OnHudRender;

        #endregion
    }
}
