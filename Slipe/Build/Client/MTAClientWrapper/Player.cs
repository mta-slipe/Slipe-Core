using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper
{
    public class Player : SharedPlayer
    {
        public Player(MultiTheftAuto.MTAElement mtaElement) : base(mtaElement)
        {
        }
    }
}
