using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper
{
    public class MTAObject : SharedObject 
    {
        public float Mass
        {
            get
            {
                return Client.GetObjectMass(element);
            }
            set
            {
                Client.SetObjectMass(element, value);
            }
        }

        public bool Breakable
        {
            get
            {
                return Client.IsObjectBreakable(element);
            }
            set
            {
                Client.SetObjectBreakable(element, value);
            }
        }

        public bool Respawns
        {
            set
            {
                Client.ToggleObjectRespawn(element, value);
            }
        }
        public MTAObject(int model, Vector3 position) : base(model, position)
        {
        }

        public MTAObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false) : base(model, position, rotation, isLowLOD)
        {
        }

        public void Break()
        {
            Client.BreakObject(element);
        }

        public void Respawn()
        {
            Client.RespawnObject(element);
        }
    }
}
