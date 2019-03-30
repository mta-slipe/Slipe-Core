using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Client.Enums;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Object containing a lot of information about various internal datum
    /// </summary>
    public class DxStatus
    {
        /// <summary>
        /// The current dx test mode.
        /// </summary>
        public TestMode TestMode { get; }

        /// <summary>
        /// The name of the graphics card.
        /// </summary>
        public string VideoCardName { get; }

        /// <summary>
        /// The installed memory in MB of the graphics card.
        /// </summary>
        public int VideoCardRAM { get; }

        /// <summary>
        /// The maximum pixel shader version of the graphics card.
        /// </summary>
        public string VideoCardPSVersion { get; }

        /// <summary>
        /// The maximum number of simultaneous render targets a shader can use.
        /// </summary>
        public int VideoCardNumRenderTargets { get; }

        /// <summary>
        /// The maximum anisotropic filtering available. (0-4 which respectively mean: off,2x,4x,8x,16x)
        /// </summary>
        public int VideoCardMaxAnisotropy { get; }

        /// <summary>
        /// The amount of memory in MB available for MTA to use. When this gets to zero, guiCreateFont, dxCreateFont and dxCreateRenderTarget will fail.
        /// </summary>
        public int VideoMemoryFreeForMTA { get; }

        /// <summary>
        /// The amount of graphic memory in MB used by custom fonts.
        /// </summary>
        public int VideoMemoryUsedByFonts { get; }

        /// <summary>
        /// The amount of graphic memory in MB used by textures.
        /// </summary>
        public int VideoMemoryUsedByTextures { get; }

        /// <summary>
        /// The amount of graphic memory in MB used by render targets.
        /// </summary>
        public int VideoMemoryUsedByRenderTargets { get; }

        /// <summary>
        /// The windowed setting.
        /// </summary>
        public bool SettingWindowed { get; }

        /// <summary>
        /// Display style when in full screen mode. (0-2 which respectively mean: Standard, Borderless window, Borderless keep res)
        /// </summary>
        public int SettingFullScreenStyle { get; }

        /// <summary>
        /// The FX Quality. (0-3)
        /// </summary>
        public int SettingFXQuality { get; }

        /// <summary>
        ///  The draw distance setting. (0-100)
        /// </summary>
        public int SettingDrawDistance { get; }

        /// <summary>
        ///  The volumetric shadows setting.
        /// </summary>
        public bool SettingVolumetricShadows { get; }

        /// <summary>
        /// The usable graphics memory setting. (64-256)
        /// </summary>
        public int SettingStreamingVideoMemoryForGTA { get; }

        /// <summary>
        /// The anisotropic filtering setting. (0-4 which respectively mean: off,2x,4x,8x,16x)
        /// </summary>
        public int SettingAnisotropicFiltering { get; }

        /// <summary>
        /// The anti-aliasing setting. (0-3 which respectively mean: off,1x,2x,3x)
        /// </summary>
        public int SettingAntiAliasing { get; }

        /// <summary>
        /// The heat haze setting.
        /// </summary>
        public bool SettingHeatHaze { get; }

        /// <summary>
        /// The grass effect setting.
        /// </summary>
        public bool SettingGrassEffect { get; }

        /// <summary>
        /// The color depth of the screen. (false is 16bit, true is 32bit)
        /// </summary>
        public bool Setting32BitColor { get; }

        /// <summary>
        /// The hud match aspect ratio setting 
        /// </summary>
        public bool SettingHUDMatchAspectRatio { get; }

        /// <summary>
        /// The aspect ratio setting ("auto", "4:3", "16:10", "16:9")
        /// </summary>
        public string SettingAspectRatio { get; }

        /// <summary>
        /// The FOV setting
        /// </summary>
        public string SettingFOV { get; }

        /// <summary>
        /// High detail vehicles setting
        /// </summary>
        public bool SettingHighDetailVehicles { get; }

        /// <summary>
        /// The allows screen uploads setting.
        /// </summary>
        public bool AllowScreenUpload { get; }

        /// <summary>
        ///  The format of the shader readable depth buffer, or 'unknown' if not available
        /// </summary>
        public string DepthBufferFormat { get; }

        /// <summary>
        /// True if the depth buffer is used, false otherwise
        /// </summary>
        public bool UsingDepthBuffer { get; }

        public DxStatus(dynamic table)
        {
            string[] t = MTAShared.GetArrayFromTable(table, "System.String");
            TestMode = (TestMode)Enum.Parse(typeof(TestMode), t[0]);
            VideoCardName = t[1];
            VideoCardRAM = Int32.Parse(t[2]);
            VideoCardPSVersion = t[3];
            VideoCardNumRenderTargets = Int32.Parse(t[4]);
            VideoCardMaxAnisotropy = Int32.Parse(t[5]);
            VideoMemoryFreeForMTA = Int32.Parse(t[6]);
            VideoMemoryUsedByFonts = Int32.Parse(t[7]);
            VideoMemoryUsedByTextures = Int32.Parse(t[8]);
            VideoMemoryUsedByRenderTargets = Int32.Parse(t[9]);
            SettingWindowed = Boolean.Parse(t[10]);
            SettingFullScreenStyle = Int32.Parse(t[11]);
            SettingFXQuality = Int32.Parse(t[12]);
            SettingDrawDistance = Int32.Parse(t[13]);
            SettingVolumetricShadows = Boolean.Parse(t[14]);
            SettingStreamingVideoMemoryForGTA = Int32.Parse(t[15]);
            SettingAnisotropicFiltering = Int32.Parse(t[16]);
            SettingAntiAliasing = Int32.Parse(t[17]);
            SettingHeatHaze = Boolean.Parse(t[18]);
            SettingGrassEffect = Boolean.Parse(t[19]);
            Setting32BitColor = Boolean.Parse(t[20]);
            SettingHUDMatchAspectRatio = Boolean.Parse(t[21]);
            SettingAspectRatio = t[22];
            SettingFOV = t[23];
            SettingHighDetailVehicles = Boolean.Parse(t[24]);
            AllowScreenUpload = Boolean.Parse(t[25]);
            DepthBufferFormat = t[26];
            UsingDepthBuffer = Boolean.Parse(t[27]);
        }
    }
}
