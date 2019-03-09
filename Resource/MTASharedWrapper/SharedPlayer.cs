using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper
{
    public class SharedPlayer: SharedElement
    {
        public SharedPlayer(Element mtaElement) : base(mtaElement)
        {
        }

        public virtual string Name
        {
            get
            {
                return Shared.GetPlayerName(element);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public static SharedPlayer GetFromName(string name)
        {
            return (SharedPlayer) SharedElementManager.Instance.GetElement(Shared.GetPlayerFromName(name));
        }
    }
}
