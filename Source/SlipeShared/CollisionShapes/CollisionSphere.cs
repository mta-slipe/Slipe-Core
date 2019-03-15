using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.CollisionShapes
{
    public class CollisionSphere: CollisionShape
    {
        public CollisionSphere(Vector3 position, float radius)
        {
            element = MTAShared.CreateColSphere(position.X, position.Y, position.Z, radius);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
