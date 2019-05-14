using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Elements.Events
{
    public class OnModelChangeArgs
    {
        /// <summary>
        /// The old model
        /// </summary>
        int OldModel { get; }

        /// <summary>
        /// The new model
        /// </summary>
        int NewModel { get; }

        internal OnModelChangeArgs(int oldModel, int newModel)
        {
            OldModel = oldModel;
            NewModel = newModel;
        }
    }
}
