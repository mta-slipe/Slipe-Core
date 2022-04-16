using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;

namespace SlipeLua.Client.Dx
{
    /// <summary>
    /// Class representing a texture or shader
    /// </summary>
    public abstract class Material
    {
        protected MtaElement materialElement;

        /// <summary>
        /// Get the material element associated
        /// </summary>
        public MtaElement MaterialElement
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
                Tuple<int, int, dynamic, dynamic> result = MtaClient.DxGetMaterialSize(materialElement);
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
                Tuple<int, int, dynamic, dynamic> result = MtaClient.DxGetMaterialSize(materialElement);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
        }

        /// <summary>
        /// Destroys the material element
        /// </summary>
        public void Destroy()
        {
            MtaShared.DestroyElement(this.materialElement);
        }
    }
}
