using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using SlipeLua.Shared.Utilities;
using SlipeLua.Client.Elements;
using SlipeLua.Client.Rendering.Events;

namespace SlipeLua.Client.Dx
{
    /// <summary>
    /// Represents a drawable image
    /// </summary>
    public class Image : Dx2DObject, IDrawable
    {
        protected bool usePath;
        protected string filePath;
        protected Material material;
        /// <summary>
        /// Width and height of the image
        /// </summary>
        public Vector2 Dimensions { get; set; }

        /// <summary>
        /// The filepath of this image
        /// </summary>
        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
                usePath = true;
            }
        }
        
        /// <summary>
        /// The material element used for this image
        /// </summary>
        public Material Material
        {
            get
            {
                return material;
            }
            set
            {
                material = value;
                usePath = false;
            }
        }

        /// <summary>
        /// The rotation of this image
        /// </summary>
        public float Rotation { get; set; }

        /// <summary>
        /// The center offset around which this image rotates
        /// </summary>
        public Vector2 RotationCenter { get; set; }

        /// <summary>
        /// Create an image from a filepath with a color
        /// </summary>
        public Image(Vector2 position, Vector2 dimensions, string filePath, float rotation, Vector2 rotationCenter, Color color, bool postGUI = false)
        {
            Position = position;
            Dimensions = dimensions;
            FilePath = filePath;
            Rotation = rotation;
            RotationCenter = rotationCenter;
            Color = color;
            PostGUI = postGUI;
            usePath = true;
        }

        /// <summary>
        /// Create an image from a filepath with rotation
        /// </summary>
        public Image(Vector2 position, Vector2 dimensions, string filePath, float rotation, Vector2 rotationCenter) : this(position, dimensions, filePath, rotation, rotationCenter, Color.White) { }

        /// <summary>
        /// Create an image from a filepath
        /// </summary>
        public Image(Vector2 position, Vector2 dimensions, string filePath, float rotation = 0.0f) : this(position, dimensions, filePath, rotation, Vector2.Zero) { }

        /// <summary>
        /// Create an image from a material with color
        /// </summary>
        public Image(Vector2 position, Vector2 dimensions, Material imageMaterial, float rotation, Vector2 rotationCenter, Color color, bool postGUI = false)
        {
            Position = position;
            Dimensions = dimensions;
            Material = imageMaterial;
            Rotation = rotation;
            RotationCenter = rotationCenter;
            Color = color;
            PostGUI = postGUI;
            usePath = false;
        }

        /// <summary>
        /// Create an image from a material with rotation
        /// </summary>
        public Image(Vector2 position, Vector2 dimensions, Material imageMaterial, float rotation, Vector2 rotationCenter) : this(position, dimensions, imageMaterial, rotation, rotationCenter, Color.White) { }

        /// <summary>
        /// Create an image from a material
        /// </summary>
        public Image(Vector2 position, Vector2 dimensions, Material imageMaterial, float rotation = 0.0f) : this(position, dimensions, imageMaterial, rotation, Vector2.Zero) { }

        public virtual bool Draw(RootElement source, OnRenderEventArgs eventArgs)
        {
            if (usePath)
                return MtaClient.DxDrawImage(Position.X, Position.Y, Dimensions.X, Dimensions.Y, FilePath, Rotation, RotationCenter.X, RotationCenter.Y, Color.Hex, PostGUI);
            else
                return MtaClient.DxDrawImage(Position.X, Position.Y, Dimensions.X, Dimensions.Y, Material?.MaterialElement, Rotation, RotationCenter.X, RotationCenter.Y, Color.Hex, PostGUI);
        }
    }
}
