using Slipe.Client.GameWorld;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Client.Elements.Events
{
    public class OnWorldSoundEventArgs
    {
        /// <summary>
        /// The world sound group
        /// </summary>
        public WorldSoundGroup Group { get; }

        /// <summary>
        /// The index of this sound in the group
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// The position at which this event is played
        /// </summary>
        public Vector3 Position { get; }

        internal OnWorldSoundEventArgs(dynamic group, dynamic index, dynamic x, dynamic y, dynamic z)
        {
            Group = (WorldSoundGroup)group;
            Index = (int)index;
            Position = new Vector3((float)x, (float)y, (float)z);
        }
    }
}
