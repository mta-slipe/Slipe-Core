using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Class representing a texture or shader
    /// </summary>
    public abstract class Material
    {
        protected MTAElement materialElement;

        /// <summary>
        /// Get the material element associated
        /// </summary>
        public MTAElement MaterialElement
        {
            get
            {
                return materialElement;
            }
        }

        /// <summary>
        /// This gets the dimensions of this material element.
        /// </summary>
        public Vector2 MaterialSize
        {
            get
            {
                Tuple<int, int, dynamic, dynamic> result = MTAClient.DxGetMaterialSize(materialElement);
                return new Vector2(result.Item1, result.Item2);
            }
        }

        /// <summary>
        /// This gets the dimensions of this material if it is a volume
        /// </summary>
        public Vector3 VolumeSize
        {
            get
            {
                Tuple<int, int, dynamic, dynamic> result = MTAClient.DxGetMaterialSize(materialElement);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
        }
    }
}
