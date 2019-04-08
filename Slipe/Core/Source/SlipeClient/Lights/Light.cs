using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;
using System.ComponentModel;

namespace Slipe.Client.Lights
{
    public class Light : PhysicalElement
    {
        #region Properties

        /// <summary>
        /// Get and set the color of this light
        /// </summary>
        public Color Color
        {
            get
            {
                Tuple<int, int, int> result = MtaClient.GetLightColor(element);
                return new Color((byte)result.Item1, (byte)result.Item2, (byte)result.Item3);
            }
            set
            {
                MtaClient.SetLightColor(element, value.R, value.G, value.B);
            }
        }

        /// <summary>
        /// Get and set the direction of this light
        /// </summary>
        public Vector3 Direction
        {
            get
            {
                Tuple<float, float, float> result = MtaClient.GetLightDirection(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
            set
            {
                MtaClient.SetLightDirection(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Get and set the radius of this light
        /// </summary>
        public float Radius
        {
            get
            {
                return MtaClient.GetLightRadius(element);
            }
            set
            {
                MtaClient.SetLightRadius(element, value);
            }
        }

        /// <summary>
        /// Get the type of this light
        /// </summary>
        public LightType LightType
        {
            get
            {
                return (LightType)MtaClient.GetLightType(element);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Light(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a light with all the parameters
        /// </summary>
        public Light(LightType type, Vector3 position, float radius, Color color, Vector3 direction, bool createShadow = false)
        {
            element = MtaClient.CreateLight((int)type, position.X, position.Y, position.Z, radius, color.R, color.G, color.B, direction.X, direction.Y, direction.Z, createShadow);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a simple red light
        /// </summary>
        public Light(LightType type, Vector3 position, float radius = 3) : this(type, position, radius, Color.Red, Vector3.Zero) { }

        #endregion

        
    }
}
