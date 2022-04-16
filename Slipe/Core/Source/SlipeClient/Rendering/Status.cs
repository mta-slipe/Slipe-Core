using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Client.Rendering
{
    /// <summary>
    /// Object containing a lot of information about various internal datum
    /// </summary>
    public class Status
    {
        /// <summary>
        /// The current dx test mode.
        /// </summary>
        public TestMode TestMode { get; set; }

        /// <summary>
        /// The name of the graphics card.
        /// </summary>
        public string VideoCardName { get; set; }

        /// <summary>
        /// The installed memory in MB of the graphics card.
        /// </summary>
        public int VideoCardRAM { get; set; }

        /// <summary>
        /// The maximum pixel shader version of the graphics card.
        /// </summary>
        public string VideoCardPSVersion { get; set; }

        /// <summary>
        /// The maximum number of simultaneous render targets a shader can use.
        /// </summary>
        public int VideoCardNumRenderTargets { get; set; }

        /// <summary>
        /// The maximum anisotropic filtering available. (0-4 which respectively mean: off,2x,4x,8x,16x)
        /// </summary>
        public int VideoCardMaxAnisotropy { get; set; }

        /// <summary>
        /// The amount of memory in MB available for MTA to use. When this gets to zero, guiCreateFont, dxCreateFont and dxCreateRenderTarget will fail.
        /// </summary>
        public int VideoMemoryFreeForMTA { get; set; }

        /// <summary>
        /// The amount of graphic memory in MB used by custom fonts.
        /// </summary>
        public int VideoMemoryUsedByFonts { get; set; }

        /// <summary>
        /// The amount of graphic memory in MB used by textures.
        /// </summary>
        public int VideoMemoryUsedByTextures { get; set; }

        /// <summary>
        /// The amount of graphic memory in MB used by render targets.
        /// </summary>
        public int VideoMemoryUsedByRenderTargets { get; set; }

        /// <summary>
        /// The windowed setting.
        /// </summary>
        public bool SettingWindowed { get; set; }

        /// <summary>
        /// Display style when in full screen mode. (0-2 which respectively mean: Standard, Borderless window, Borderless keep res)
        /// </summary>
        public int SettingFullScreenStyle { get; set; }

        /// <summary>
        /// The FX Quality. (0-3)
        /// </summary>
        public int SettingFXQuality { get; set; }

        /// <summary>
        ///  The draw distance setting. (0-100)
        /// </summary>
        public int SettingDrawDistance { get; set; }

        /// <summary>
        ///  The volumetric shadows setting.
        /// </summary>
        public bool SettingVolumetricShadows { get; set; }

        /// <summary>
        /// The usable graphics memory setting. (64-256)
        /// </summary>
        public int SettingStreamingVideoMemoryForGTA { get; set; }

        /// <summary>
        /// The anisotropic filtering setting. (0-4 which respectively mean: off,2x,4x,8x,16x)
        /// </summary>
        public int SettingAnisotropicFiltering { get; set; }

        /// <summary>
        /// The anti-aliasing setting. (0-3 which respectively mean: off,1x,2x,3x)
        /// </summary>
        public int SettingAntiAliasing { get; set; }

        /// <summary>
        /// The heat haze setting.
        /// </summary>
        public bool SettingHeatHaze { get; set; }

        /// <summary>
        /// The grass effect setting.
        /// </summary>
        public bool SettingGrassEffect { get; set; }

        /// <summary>
        /// The color depth of the screen. (false is 16bit, true is 32bit)
        /// </summary>
        public bool Setting32BitColor { get; set; }

        /// <summary>
        /// The hud match aspect ratio setting 
        /// </summary>
        public bool SettingHUDMatchAspectRatio { get; set; }

        /// <summary>
        /// The aspect ratio setting ("auto", "4:3", "16:10", "16:9")
        /// </summary>
        public string SettingAspectRatio { get; set; }

        /// <summary>
        /// The FOV setting
        /// </summary>
        public int SettingFOV { get; set; }

        /// <summary>
        /// High detail vehicles setting
        /// </summary>
        public bool SettingHighDetailVehicles { get; set; }

        /// <summary>
        /// The allows screen uploads setting.
        /// </summary>
        public bool AllowScreenUpload { get; set; }

        /// <summary>
        ///  The format of the shader readable depth buffer, or 'unknown' if not available
        /// </summary>
        public string DepthBufferFormat { get; set; }

        /// <summary>
        /// True if the depth buffer is used, false otherwise
        /// </summary>
        public bool UsingDepthBuffer { get; set; }

        /// <summary>
        /// Create a new status object
        /// </summary>
        public Status()
        {
            Update();
        }

        /// <summary>
        /// Update the status
        /// </summary>
        public void Update()
        {
            Dictionary<string, dynamic> t = MtaShared.GetDictionaryFromTable(MtaClient.DxGetStatus(), "System.String", "System.Dynamic");
            TestMode = (TestMode)Enum.Parse(typeof(TestMode), t["TestMode"]);
            VideoCardName = (string)t["VideoCardName"];
            VideoCardRAM = (int)t["VideoCardRAM"];
            VideoCardPSVersion = (string)t["VideoCardPSVersion"];
            VideoCardNumRenderTargets = (int)t["VideoCardNumRenderTargets"];
            VideoCardMaxAnisotropy = (int)t["VideoCardMaxAnisotropy"];
            VideoMemoryFreeForMTA = (int)t["VideoMemoryFreeForMTA"];
            VideoMemoryUsedByFonts = (int)t["VideoMemoryUsedByFonts"];
            VideoMemoryUsedByTextures = (int)t["VideoMemoryUsedByTextures"];
            VideoMemoryUsedByRenderTargets = (int)t["VideoMemoryUsedByRenderTargets"];
            SettingWindowed = (bool)t["SettingWindowed"];
            SettingFullScreenStyle = (int)t["SettingFullScreenStyle"];
            SettingFXQuality = (int)t["SettingFXQuality"];
            SettingDrawDistance = (int)t["SettingDrawDistance"];
            SettingVolumetricShadows = (bool)t["SettingVolumetricShadows"];
            SettingStreamingVideoMemoryForGTA = (int)t["SettingStreamingVideoMemoryForGTA"];
            SettingAnisotropicFiltering = (int)t["SettingAnisotropicFiltering"];
            SettingAntiAliasing = (int)t["SettingAntiAliasing"];
            SettingHeatHaze = (bool)t["SettingHeatHaze"];
            SettingGrassEffect = (bool)t["SettingGrassEffect"];
            Setting32BitColor = (bool)t["Setting32BitColor"];
            SettingHUDMatchAspectRatio = (bool)t["SettingHUDMatchAspectRatio"];
            SettingAspectRatio = (string)t["SettingAspectRatio"];
            SettingFOV = (int)t["SettingFOV"];
            SettingHighDetailVehicles = (bool)t["SettingHighDetailVehicles"];
            AllowScreenUpload = (bool)t["AllowScreenUpload"];
            DepthBufferFormat = (string)t["DepthBufferFormat"];
            UsingDepthBuffer = (bool)t["UsingDepthBuffer"];
        }
    }
}
