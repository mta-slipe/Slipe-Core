using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Client.Sounds;

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

        /// <summary>
        /// Get the Engine object
        /// </summary>
        public static Engine Engine
        {
            get
            {
                return Engine.Instance;
            }
        }
        

        /// <summary>
        /// Get if voice is currently enabled
        /// </summary>
        public static bool IsVoiceEnabled
        {
            get
            {
                return MTAShared.IsVoiceEnabled();
            }
        }

        /// <summary>
        /// Get and set the radio channel that's playing on the client (even when not in a vehicle)
        /// </summary>
        public static RadioStation ActiveRadioStation
        {
            get
            {
                return (RadioStation)MTAClient.GetRadioChannel();
            }
            set
            {
                MTAClient.SetRadioChannel((int)value);
            }
        }
    }
}
