using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper.CollisionShapes
{
    public class CollisionShape: SharedElement
    {
        public string ShapeType { get { return Shared.GetColShapeType(element); } }
        
        public bool IsInside(Vector3 position)
        {
            return Shared.IsInsideColShape(element, position.x, position.y, position.z);
        }

        public bool IsElementWithin(SharedElement element)
        {
            return Shared.IsElementWithinColShape(this.element, element.MTAElement);
        }

        public List<SharedElement> GetElementsWithin()
        {
            return Shared.GetListFromTable(Shared.GetElementsWithinColShape(element, null));
        }



        public override void HandleEvent(string eventName, MultiTheftAuto.Element element, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            switch (eventName)
            {
                case "onColShapeHit":
                    OnHit?.Invoke((SharedElement)p1, (bool) p2);
                    break;
                case "onClientColShapeHit":
                    OnHit?.Invoke((SharedElement)p1, (bool) p2);
                    break;
                case "onColShapeLeave":
                    OnLeave?.Invoke((SharedElement)p1, (bool) p2);
                    break;
                case "onClientColShapeLeave":
                    OnLeave?.Invoke((SharedElement)p1, (bool) p2);
                    break;
            }
        }

        public delegate void OnHitHandler(SharedElement element, bool matchingDimension);
        public event OnHitHandler OnHit;
        public delegate void OnLeaveHandler(SharedElement element, bool matchingDimension);
        public event OnLeaveHandler OnLeave;

    }
}
