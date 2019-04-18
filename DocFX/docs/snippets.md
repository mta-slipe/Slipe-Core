# Snippets
Here you'll find an assortiment of code snippets to see some examples of Slipe in action.

## TeamVehicle
This example demonstrates how you can extend a base MTA element and add extra functionality
```csharp
namespace ServerSide
{
    // A vehicle that is locked to a team
    public class TeamVehicle : Vehicle
    {
        // The team that this vehicle is locked to
        public Team Team { get; }

        // Create a new vehicle locked to a team
        public TeamVehicle(VehicleModel model, Vector3 position, Team team) : base(model, position)
        {
            Team = team;           

            OnStartEnter += (Player player, Seat seat, Player jacked, Door door) =>
            {
                if (seat == Seat.FrontLeft && player.Team != team)
                    Event.Cancel();
            };
        }
    }
}
```

## Gates
This example demonstrates the interaction between different classes and the benefits of interfaces; A `Gategroup` can now contain both gates and different gate groups.
```csharp
namespace ServerSide
{
    public interface IGateable
    {
        void Open();
        void Close();
    }
   
    public class Gate : WorldObject, IGateable
    {
        private Vector3 endPos;
        private Vector3 startPos;
        private bool isOpen;

        // Create an airport gate
        public Gate(Vector3 startPosition, Vector3 rotation, Vector3 endPosition) 
            : base(989, startPosition, rotation)
        {
            startPos = startPosition;
            endPos = endPosition;
        }

        // Open the gate!
        public void Open()
        {
            if(!isOpen)
                Move(2000, endPos);
            isOpen = true;
        }

        // Close the gate!
        public void Close()
        {
            if(isOpen)
                Move(2000, startPos);
            isOpen = false;
        }
    }
    
    public class GateGroup : CollisionCuboid, IGateable
    {
        private IGateable[] gates;

        // Create a gate group
        public GateGroup(Vector3 southWest, Vector3 northEast, IGateable[] gates) 
            : base(southWest, southWest - northEast))
        {
            this.gates = gates;
            OnHit += (PhysicalElement element, bool matchingDimension) =>
            {
                if (matchingDimension)
                    Open();
            };

            OnLeave += (PhysicalElement element, bool matchingDimension) => 
            {
                int playersWithin = GetElementsWithinOfType(typeof(Player)).Length;
                if (matchingDimension && playersWithin <= 0)
                    Close();
            };
        }

        // Open the gates!
        public void Open()
        {
            foreach (IGateable gate in gates)
            {
                gate.Open();
            }
        }

        // Close the gates!
        public void Close()
        {
            foreach (IGateable gate in gates)
            {
                gate.Close();
            }
        }
    }
}
```

## Police Patriot
This example shows one of many extended data types that are implemented in Slipe. Just like with `Vehicle.Handling` one can also get the Sirens of a vehicle as an object and change them.
```csharp
namespace ServerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle patriot = new Vehicle(VehicleModel.Patriot, new Vector3(0, 15, 3));
            patriot.Sirens.Add(new Vector3(-0.6f, 1, 0.5f), Color.Red, 200);
            patriot.Sirens.Add(new Vector3(0.6f, 1, 0.5f), new Color(0, 0, 255), 200);
            patriot.Sirens.On = true;
            patriot.Sirens.Silent = true;
        }
    }
}
```