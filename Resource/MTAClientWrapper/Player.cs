using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper
{
    public class Player : SharedPlayer
    {
        public Player(MultiTheftAuto.Element mtaElement) : base(mtaElement)
        {
        }
    }
}
