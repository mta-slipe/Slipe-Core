# Inheritance

C# inheritance is fully operationable in Slipe. This means that you can create classes that inherit from other classes. If you are not familiar with inheritance, you can read up on inheritance [here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance).

## Inheriting from Slipe classes

A common case of inheritance would be to inherit from an already existing Slipe class. This is done just like you would inherit from any other class.
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

However, the only vehicles that are affected by this class implementation are vehicle that are instantiated by this Slipe resource. Any vehicle created by other resources won't be affected.

## Defining default classes

In some cases you want to apply a new default class to all elements of a specific type. This would mean that all elements both existing and created by other resources are instantiated as your new default class. We can do this in Slipe by adding the ``DefaultElementClass`` attribute. This attribute, on a class, tells Slipe to instantiate any Mta element it encounters not as the base Slipe class but as your new default class. The parameter for this attribute is the type of the Mta element.

This example extends the base player class and adds some functionality on the constructor. This class is then applied to any player both in the server while starting your Slipe resource as joining later.

```csharp
class Program
{
    static void Main(string[] args)
    {
        new Program();
    }

    public Program()
    {
        // Spawn a player in Blueberry
        Player.OnJoin += (Player p) =>
        {
            p.Spawn(new Vector3(0, 0, 5));
            p.Camera.Target = p;
        };
    }
}

[DefaultElementClass(ElementType.Player)]
public class MyPlayer : Player
{
    public MyPlayer(MtaElement element) : base(element)
    {

        this.OnSpawn += (Vector3 position, float rotation, Team team, PedModel model, int interior, int dimension) =>
        {
            this.Camera.Fade(CameraFade.In);
        };
    }
}
```

Any class that extends a base Slipe class and wishes to use the ``DefaultElementClass`` attribute also needs to define a constructor that takes an ``MtaElement``. This ensures that the right element is passed on to parent constructors. Besides this ``MtaElement`` constructor, you can ofcourse also define your own.

Another example that has two different constructors:

```csharp
[DefaultElementClass(ElementType.Vehicle)]
public class MyVehicle : Vehicle
{
    public MyVehicle(MtaElement element) : base(element)
    {
        PrimaryColor = Color.ForestGreen;
    }

    public MyVehicle(Vector3 pos, VehicleModel model) : base(model, pos)
    {
        PrimaryColor = Color.ForestGreen;
    }

}
``` 

When starting this resource, all vehicles in your server will turn green.