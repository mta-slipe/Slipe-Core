using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper
{
    public class SharedPlayer: SharedElement
    {
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
    }
}
