using Slipe.Server.GameWorld;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ServerSide
{
    public class Gate : WorldObject, IGateable
    {
        private Vector3 endPos;
        private Vector3 startPos;
        private bool isOpen;

        /// <summary>
        /// Create an airport gate
        /// </summary>
        /// <param name="startPosition">The position when closed</param>
        /// <param name="rotation">The rotation of the gate</param>
        /// <param name="endPosition">The position when opened</param>
        public Gate(Vector3 startPosition, Vector3 rotation, Vector3 endPosition) 
            : base(989, startPosition, rotation)
        {
            startPos = startPosition;
            endPos = endPosition;
        }

        /// <summary>
        /// Open the gate!
        /// </summary>
        public void Open()
        {
            if(!isOpen)
                Move(2000, endPos);
            isOpen = true;
        }

        /// <summary>
        /// Close the gate!
        /// </summary>
        public void Close()
        {
            if(isOpen)
                Move(2000, startPos);
            isOpen = false;
        }
    }
}
