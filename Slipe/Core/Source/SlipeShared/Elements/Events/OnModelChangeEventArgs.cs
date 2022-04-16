using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Elements.Events
{
    public class OnModelChangeEventArgs
    {
        /// <summary>
        /// The old model
        /// </summary>
        int OldModel { get; }

        /// <summary>
        /// The new model
        /// </summary>
        int NewModel { get; }

        internal OnModelChangeEventArgs(dynamic oldModel, dynamic newModel)
        {
            OldModel = (int) oldModel;
            NewModel = (int) newModel;
        }
    }
}
