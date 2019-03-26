using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;

namespace Slipe.Client
{
    /// <summary>
    /// Static class that handles calls to functions related to the client
    /// </summary>
    public static class Client
    {
        /// <summary>
        /// Get the renderer object
        /// </summary>
        public static Renderer Renderer
        {
            get
            {
                return Slipe.Client.Renderer.Instance;
            }
        }
    }
}
