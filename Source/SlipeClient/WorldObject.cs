using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Client
{
    public class WorldObject : SharedWorldObject
    {
        public float Mass
        {
            get
            {
                return MTAClient.GetObjectMass(element);
            }
            set
            {
                MTAClient.SetObjectMass(element, value);
            }
        }

        public bool Breakable
        {
            get
            {
                return MTAClient.IsObjectBreakable(element);
            }
            set
            {
                MTAClient.SetObjectBreakable(element, value);
            }
        }

        public bool Respawns
        {
            set
            {
                MTAClient.ToggleObjectRespawn(element, value);
            }
        }

        public WorldObject(MTAElement element): base(element)
        {

        }

        public WorldObject(int model, Vector3 position) : base(model, position)
        {
        }

        public WorldObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false) : base(model, position, rotation, isLowLOD)
        {
        }

        public void Break()
        {
            MTAClient.BreakObject(element);
        }

        public void Respawn()
        {
            MTAClient.RespawnObject(element);
        }
    }
}
