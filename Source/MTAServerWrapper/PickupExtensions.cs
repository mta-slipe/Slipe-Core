using System;
using System.Collections.Generic;
using System.Text;
using MTASharedWrapper.Pickups;
using MultiTheftAuto;

namespace MTAServerWrapper
{
    public static class PickupExtensions
    {
        public static int GetRespawnInterval(this Pickup source)
        {
            return Server.GetPickupRespawnInterval(source.MTAElement);
        }

        public static bool IsSpawned(this Pickup source)
        {
            return Server.IsPickupSpawned(source.MTAElement);
        }

        public static bool SetRespawnInterval(this Pickup source, int ms)
        {
            return Server.SetPickupRespawnInterval(source.MTAElement, ms);
        }
    }
}
