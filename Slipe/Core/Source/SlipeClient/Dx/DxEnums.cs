using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Representing the desired texture format
    /// </summary>
    public enum TextureFormat
    {
        Argb,
        Dxt1,
        Dxt3,
        Dxt5
    }

    /// <summary>
    /// Representing the desired texture edge handling, which can be one of:
    /// </summary>
    public enum TextureEdge
    {
        Wrap,
        Clamp,
        Mirror,
        Border,
        MirrorOnce
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
    /// Represents different image formats
    /// </summary>
    public enum ImageFormat
    {
        plain,
        png,
        jpeg
    }

    /// <summary>
    /// Represents different primitive types
    /// </summary>
    public enum PrimitiveType
    {
        PointList,
        LineList,
        LineStrip,
        TriangleList,
        TriangleStrip,
        TriangleFan
    }
}
