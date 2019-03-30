using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Enums
{
    /// <summary>
    /// Representing the desired texture format
    /// </summary>
    public enum TextureFormat
    {
        argb,
        dxt1,
        dxt3,
        dxt5
    }

    /// <summary>
    /// Representing the desired texture edge handling, which can be one of:
    /// </summary>
    public enum TextureEdge
    {
        wrap,
        clamp,
        mirror,
        border,
        mirror_once
    }

    /// <summary>
    /// Representing the desired texture type, which can be one of:
    /// </summary>
    public enum TextureType
    {
        TwoDimensional,
        ThreeDimensional,
        Cube
    }

    /// <summary>
    /// Represents valid shader types
    /// </summary>
    public enum ShaderElementType
    {
        World,
        Ped,
        Vehicle,
        Object,
        Other,
        All
    }

    /// <summary>
    /// Represents Dx draw blendmodes
    /// </summary>
    public enum BlendMode
    {
        blend,
        add,
        modulate_add,
        overwrite
    }

    /// <summary>
    /// Represents different image formats
    /// </summary>
    public enum ImageFormat
    {
        plain,
        png,
        jpeg
    }

    /// <summary>
    /// Represents dx testmodes to simulate different memory states
    /// </summary>
    public enum TestMode
    {
        none,
        no_mem,
        low_mem,
        no_shader
    }
}
