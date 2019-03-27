using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;

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
    }
}
