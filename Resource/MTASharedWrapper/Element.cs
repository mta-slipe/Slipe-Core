using System;
using System.Collections.Generic;
using System.Text;
using MultiTheftAuto;

namespace MTASharedWrapper
{
    public class Element
    {
        protected MultiTheftAuto.Element element;

        public bool SetPosition(Vector3 position)
        {
            return Server.SetElementPosition(element, position.x, position.y, position.z, false);
        }
        public bool SetRotation(Vector3 rotation)
        {
            return Server.SetElementRotation(element, rotation.x, rotation.y, rotation.z, "default", false);
        }
    }
}
