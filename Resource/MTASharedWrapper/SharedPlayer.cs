using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper
{
    public class SharedPlayer: SharedElement
    {
        public string Name
        {
            get
            {
                return Server.GetPlayerName(element);
            }
            set
            {
                Server.SetPlayerName(element, value);
            }
        }
    }
}
