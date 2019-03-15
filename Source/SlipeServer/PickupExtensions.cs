using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Pickups;
using Slipe.MTADefinitions;

namespace Slipe.Server
{
    public static class PickupExtensions
    {
        public static int GetRespawnInterval(this Pickup source)
        {
            return MTAServer.GetPickupRespawnInterval(source.MTAElement);
        }

        public static bool IsSpawned(this Pickup source)
        {
            return MTAServer.IsPickupSpawned(source.MTAElement);
        }

        public static bool SetRespawnInterval(this Pickup source, int ms)
        {
            return MTAServer.SetPickupRespawnInterval(source.MTAElement, ms);
        }
    }
}
