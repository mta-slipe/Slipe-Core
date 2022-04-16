using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Peds.Events
{
    public class OnStepEventArgs
    {
        /// <summary>
        /// True if the step was taken with the left foot, false for right
        /// </summary>
        public bool LeftFoot { get; }
        internal OnStepEventArgs(dynamic left)
        {
            LeftFoot = (bool)left;
        }
    }
}
