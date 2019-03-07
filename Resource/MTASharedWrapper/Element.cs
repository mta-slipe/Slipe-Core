using System;
using System.Collections.Generic;
using System.Text;
using MultiTheftAuto;

namespace MTASharedWrapper
{
    public class Element
    {
        protected MultiTheftAuto.Element element;

        public bool Destroy()
        {
            return Server.DestroyElement(element);
        }

        public Vector3 Position
        {
            get
            {
                Tuple<float, float, float> position = Server.GetElementPosition(element);
                return new Vector3(position.Item1, position.Item2, position.Item3);
            }
            set
            {
                Server.SetElementPosition(element, value.x, value.y, value.z, false);
            }
        }

        public Vector3 Rotation
        {
            get
            {
                Tuple<float, float, float> rotation = Server.GetElementRotation(element, "default");
                return new Vector3(rotation.Item1, rotation.Item2, rotation.Item3);
            }
            set
            {
                Server.SetElementRotation(element, value.x, value.y, value.z, "default", false);
            }
        }

        public int Dimension
        {
            get
            {
                return Server.GetElementDimension(element);
            }
            set
            {
                Server.SetElementDimension(element, value);
            }
        }

        public int Interior
        {
            get
            {
                return Server.GetElementInterior(element);
            }
            set
            {
                Vector3 position = Position;
                Server.SetElementInterior(element, value, position.x, position.y, position.z);
            }
        }

        public bool Frozen
        {
            get
            {
                return Server.IsElementFrozen(element);
            }
            set
            {
                Server.SetElementFrozen(element, value);
            }
        }


    }
}
