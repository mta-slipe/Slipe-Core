using System;
using System.Collections.Generic;
using System.Text;
using MTASharedWrapper.CollisionShapes;
using MultiTheftAuto;
using System.Numerics;

namespace MTASharedWrapper
{
    public class Element
    {
        protected internal MTAElement element;

        public static Element Root { get { return ElementManager.Instance.Root; } }

        public MTAElement MTAElement
        {
            get
            {
                return element;
            }
        }

        public Vector3 Position
        {
            get
            {
                Tuple<float, float, float> position = Shared.GetElementPosition(element);
                return new Vector3(position.Item1, position.Item2, position.Item3);
            }
            set
            {
                Shared.SetElementPosition(element, value.X, value.Y, value.Z, false);
            }
        }

        public Vector3 Rotation
        {
            get
            {
                Tuple<float, float, float> rotation = Shared.GetElementRotation(element, "default");
                return new Vector3(rotation.Item1, rotation.Item2, rotation.Item3);
            }
            set
            {
                Shared.SetElementRotation(element, value.X, value.Y, value.Z, "default", false);
            }
        }

        public int Dimension
        {
            get
            {
                return Shared.GetElementDimension(element);
            }
            set
            {
                Shared.SetElementDimension(element, value);
            }
        }

        public int Interior
        {
            get
            {
                return Shared.GetElementInterior(element);
            }
            set
            {
                Vector3 position = Position;
                Shared.SetElementInterior(element, value, position.X, position.Y, position.Z);
            }
        }

        public bool Frozen
        {
            get
            {
                return Shared.IsElementFrozen(element);
            }
            set
            {
                Shared.SetElementFrozen(element, value);
            }
        }

        public int Alpha
        {
            get
            {
                return Shared.GetElementAlpha(element);
            }
            set
            {
                Shared.SetElementAlpha(element, value);
            }
        }

        public float Health
        {
            get
            {
                return Shared.GetElementHealth(element);
            }
            set
            {
                Shared.SetElementHealth(element, value);
            }
        }

        public Vector3 Velocity
        {
            get
            {
                Tuple<float, float, float> velocity = Shared.GetElementVelocity(element);
                return new Vector3(velocity.Item1, velocity.Item2, velocity.Item3);
            }
            set
            {
                Shared.SetElementVelocity(element, value.X, value.Y, value.Z);
            }
        }
        
        public int Model
        {
            get
            {
                return Shared.GetElementModel(element);
            }
            set
            {
                Shared.SetElementModel(element, value);
            }
        }

        public CollisionShape CollisionShape {
            get
            {
                return (CollisionShape) ElementManager.Instance.GetElement(Shared.GetElementColShape(element));
            }
        }

        public string Type { get { return Shared.GetElementType(element); } }

        public Element()
        {
        }

        public Element(MTAElement mtaElement)
        {
            element = mtaElement;
            ElementManager.Instance.RegisterElement(this);
        }

        public bool Destroy()
        {
            return Shared.DestroyElement(element);
        }

        public bool AttachTo(Element element, Vector3 offset, Vector3 rotationOffset)
        {
            return Shared.AttachElements(this.element, element.element, offset.X, offset.Y, offset.Z, rotationOffset.X, rotationOffset.Y, rotationOffset.Z);
        }

        public bool AttachTo(Element element, Vector3 offset)
        {
            return AttachTo(element, offset, new Vector3(0, 0, 0));
        }

        public void AddEventHandler(string eventName, bool propagated = true, string priorty = "normal") {
            ElementManager.Instance.AddEventHandler(this, eventName, propagated, priorty);
        }

        public virtual void HandleEvent(string eventName, MTAElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            Console.WriteLine(eventName + " has been triggered");

            if (this == Root)
            {
                OnRootEvent?.Invoke(eventName, source, p1, p2, p3, p4, p5, p6, p7, p8);
            }
        }

        public delegate void OnRootEventHandler(string eventName, MTAElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8);
        public static event OnRootEventHandler OnRootEvent;
    }
}
