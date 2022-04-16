using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Client.Vehicles.Events
{
    public class OnCollisionEventArgs
    {
        /// <summary>
        /// The element with which the vehicle colided
        /// </summary>
        public PhysicalElement Element { get; }

        /// <summary>
        /// The force of the collision
        /// </summary>
        public float Force { get; }

        /// <summary>
        /// The part of the element if any
        /// </summary>
        public Part Part { get; }

        /// <summary>
        /// The world position of the collision
        /// </summary>
        public Vector3 Position { get; }

        /// <summary>
        /// The normal with which was collided
        /// </summary>
        public Vector3 Normal { get; }

        /// <summary>
        /// The model of the collided element
        /// </summary>
        public int Model { get; }

        internal OnCollisionEventArgs(MtaElement hitElement, dynamic force, dynamic bodyPart, dynamic cx, dynamic cy, dynamic cz, dynamic nx, dynamic ny, dynamic nz, dynamic model)
        {
            Element = ElementManager.Instance.GetElement<PhysicalElement>(hitElement);
            Force = (float)force;
            Part = (Part)bodyPart;
            Position = new Vector3((float)cx, (float)cy, (float)cz);
            Normal = new Vector3((float)nx, (float)ny, (float)nz);
            Model = (int)model;
        }
    }
}
