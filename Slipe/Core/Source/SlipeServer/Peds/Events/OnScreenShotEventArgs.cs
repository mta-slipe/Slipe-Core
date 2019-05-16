using Slipe.MtaDefinitions;
using Slipe.Server.Resources;
using Slipe.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnScreenShotEventArgs
    {
        /// <summary>
        /// The resource that took the screen shot
        /// </summary>
        public Resource Resource { get; }

        /// <summary>
        /// The status of the screen shot
        /// </summary>
        public StatusCode Status { get; }

        /// <summary>
        /// Contains the JPEG image data.
        /// </summary>
        public string ImageData { get; }

        /// <summary>
        /// An int representing the server tick count when the capture was taken.
        /// </summary>
        public int TimeStamp { get; }

        /// <summary>
        /// A string passed to takePlayerScreenShot.
        /// </summary>
        public string Tag { get; }

        internal OnScreenShotEventArgs(MtaResource resource, dynamic status, dynamic imageData, dynamic timeStamp, dynamic tag)
        {
            Resource = Resource.Get(resource);
            Status = (StatusCode) status;
            ImageData = (string) imageData;
            TimeStamp = (int) timeStamp;
            Tag = (string) tag;
        }
    }
}
