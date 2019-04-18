# Utilities
Slipe offers a range of classes that are specifically designed to ease up development for MTA.

## Shared.Utilities.Color
The color class is passed to any method that requiers a color. It consists of an red, green, blue and alpha value but you can also get the hexadecimal representation. One can construct a color from both r,g,b(,a) value but also from an integer, byte or hexadecimal, for which it uses implicit casts. Besides this, the `Color` class provides properties for almost all colors one can think of.
```csharp
namespace  ServerTest
{
    class  Program
    {
        static  void Main(string[] args)
        {
            Color blue = new  Color(0x0000ff);
            Color hotPink = Color.HotPink;
            Color red = new Color(255, 0, 0);
            
            // Color: 0, 0, 255, 255
            Console.WriteLine("Color: {0}, {1}, {2}, {3}", blue.R, blue.G, blue.B, blue.A);
        }
    }
}
```
## Shared.Helpers.EasingFunction
The `EasingFunction` class wraps the easing utilities provided by MTA. It is passed as a parameter to the `WorldObject.Move()` method and it can be used to interpolate easing values between two `floats` or `Vectors`. 
```csharp
namespace  ServerTest
{
    class  Program
    {
        static  void Main(string[] args)
        {
            WorldObject garbage = new WorldObject(1337, new Vector3(0, 0, 4));
            garbage.Move(2000, new Vector3(10, 0, 4), Vector3.Zero, EasingFunction.InOutElastic);
        }
    }
}
```
## Client.SightLines
The `SightLine` class can be used for "raytracing" in MTA. It is a wrapper for the [processLineOfSight](https://wiki.multitheftauto.com/wiki/ProcessLineOfSight), [isLineOfSightClear](https://wiki.multitheftauto.com/wiki/IsLineOfSightClear) and [testLineAgainstWater](https://wiki.multitheftauto.com/wiki/TestLineAgainstWater) functions. Just as with more elements (lights, Gui elements etc.), one can attach this object to any Physical Element so you don't have to worry about updating the positions. The following example is the Slipe implementation of the script example you'll find at [isLineOfSightClear](https://wiki.multitheftauto.com/wiki/IsLineOfSightClear):
```csharp
class Follower : Ped
{
    private Player player;
    private SightLine[] sightLines;

    public Follower(Player player)
        : base(PedModel.cj, player.Position + player.ForwardVector * -4)
    {
        this.player = player;            
        sightLines = new SightLine[10];

        for (int i=0; i <= 9; i++)
        {
            SightLine s = new SightLine(this, new Vector3(0, 1, -0.5f + i * 0.2f), Matrix4x4.Identity);
            s.CheckPeds = false;                
            s.Debug = true; // For debug purposes, we draw the line
            sightLines[i] = s;
        }

        Timer updateTimer = new Timer(50);
        updateTimer.Elapsed += Update;
        updateTimer.Enabled = true;
    }

    private void Update(Object source, ElapsedEventArgs e)
    {
        // Calculate the distance between the follower and the player
        float distance = Vector3.Distance(player.Position, this.Position);
        this.SetControlState(AnalogControl.forwards, distance >= 4);

        if (distance < 4)
            return;

        // Calculate the rotation between ped and player position
        float angle = - NumericHelper.ToDegrees((float) Math.Atan2(player.Position.X - this.Position.X, player.Position.Y - this.Position.Y));
        this.Rotation = new Vector3(0, 0, angle < 0 ? angle + 360 : angle);

        // Loop through all the sightlines to see if one collides
        bool clear = true;
        foreach(SightLine s in sightLines)
        {
            clear = s.IsClear;
            if (!clear)
                break;
        }

        // Check if everything is clear
        this.SetControlState(AnalogControl.jump, !clear);

        // Run if the player is too far away
        this.SetControlState(AnalogControl.sprint, distance > 15);
    }
}
```