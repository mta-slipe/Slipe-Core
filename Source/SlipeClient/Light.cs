using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared;
using Slipe.Client.Enums;
using System.Numerics;

namespace Slipe.Client
{
    public class Light : PhysicalElement
    {
        /// <summary>
        /// Create a light from an existing MTA light element
        /// </summary>
        public Light(MTAElement element) : base (element) { }

        /// <summary>
        /// Create a light with all the parameters
        /// </summary>
        public Light(LightTypeEnum type, Vector3 position, float radius, Color color, Vector3 direction, bool createShadow = false)
        {
            element = MTAClient.CreateLight((int)type, position.X, position.Y, position.Z, radius, color.R, color.G, color.B, direction.X, direction.Y, direction.Z, createShadow);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a simple red light
        /// </summary>
        public Light(LightTypeEnum type, Vector3 position, float radius = 3) : this(type, position, radius, Color.Red, Vector3.Zero) { }

        /// <summary>
        /// Get and set the color of this light
        /// </summary>
        public Color Color
        {
            get
            {
                Tuple<int, int, int> result = MTAClient.GetLightColor(element);
                return new Color((byte) result.Item1, (byte)result.Item2, (byte)result.Item3);
            }
            set
            {
                MTAClient.SetLightColor(element, value.R, value.G, value.B);
            }
        }

        /// <summary>
        /// Get and set the direction of this light
        /// </summary>
        public Vector3 Direction
        {
            get
            {
                Tuple<float, float, float> result = MTAClient.GetLightDirection(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
            set
            {
                MTAClient.SetLightDirection(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Get and set the radius of this light
        /// </summary>
        public float Radius
        {
            get
            {
                return MTAClient.GetLightRadius(element);
            }
            set
            {
                MTAClient.SetLightRadius(element, value);
            }
        }

        /// <summary>
        /// Get the type of this light
        /// </summary>
        public LightTypeEnum LightType
        {
            get
            {
                return (LightTypeEnum) MTAClient.GetLightType(element);
            }
        }
    }
}
