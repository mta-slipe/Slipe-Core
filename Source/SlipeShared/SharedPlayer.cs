using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared
{
    public class SharedPlayer: PhysicalElement
    {
        public SharedPlayer(MTAElement mtaElement) : base(mtaElement)
        {
        }

        public virtual string Name
        {
            get
            {
                return MTAShared.GetPlayerName(element);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public static SharedPlayer GetFromName(string name)
        {
            MTAElement mtaElement = MTAShared.GetPlayerFromName(name);
            return (SharedPlayer)ElementManager.Instance.GetElement(mtaElement);
        }
    }
}
