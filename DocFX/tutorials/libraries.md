# Implemented system components
Slipe grants you access to some powerful .NET core libraries. Using these libraries allows you to write your code conform to C# convention and enables you to find more examples of these libraries in use online. As with all of these libraries, you can find more documentation on their respective websites.

## System.Numerics
The [System.Numerics](https://docs.microsoft.com/en-us/dotnet/api/system.numerics?view=netframework-4.7.2) namespace contains numeric types that complement the numeric primitives, such as [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte?view=netframework-4.7.2), [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=netframework-4.7.2), and [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32?view=netframework-4.7.2), that are defined by .NET. All numeric primitives are implemented with an exception of [BigInteger](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.biginteger?view=netframework-4.7.2). Matrices, complex numbers, planes, quaternions and vectors are essential to any graphical development environment. The methods implemented in this library are essential to any linear algebraic operation and usually you won't have to define such an operation yourself anymore.

#### Vectors
Most essential are the [Vector2](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector2?view=netframework-4.7.2) and [Vector3](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3?view=netframework-4.7.2) structs which are fully integrated in Slipe. All methods concerning world position or screen position have these structs as parameters. All [Physical Elements]([https://mta-slipe.com/api/shared/Slipe.Shared.Elements.PhysicalElement.html](https://mta-slipe.com/api/shared/Slipe.Shared.Elements.PhysicalElement.html)) also have useful properties like f.e. [ForwardVector]([https://mta-slipe.com/api/shared/Slipe.Shared.Elements.PhysicalElement.html#Slipe_Shared_Elements_PhysicalElement_ForwardVector](https://mta-slipe.com/api/shared/Slipe.Shared.Elements.PhysicalElement.html#Slipe_Shared_Elements_PhysicalElement_ForwardVector))  which allows you to get positions relative to the rotation of the element. Other vector methods that can come in handy in MTA are [Lerp()](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.lerp?view=netframework-4.7.2#System_Numerics_Vector3_Lerp_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_), [Reflect()](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.reflect?view=netframework-4.7.2#System_Numerics_Vector3_Reflect_System_Numerics_Vector3_System_Numerics_Vector3_) and [Transform()](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3.transform?view=netframework-4.7.2#System_Numerics_Vector3_Transform_System_Numerics_Vector3_System_Numerics_Matrix4x4_)
```csharp
	using System.Numerics;
	
	// Have an AK-47 drop on the ground 3 units behind this vehicle
    public void DropWeapon()
    {
      Vector3 position = Position + ForwardVector * -3;
      new Pickup(position, SharedWeaponModel.Ak47);
    }
```

#### Quaternions
Although not requiered, some elements can be rotated using [Quaternions](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.quaternion?view=netframework-4.7.2) instead of regular Euler angles ([Vector3](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.vector3?view=netframework-4.7.2)). Using quaternions is in some cases even the only solution to complex rotational problems. The downside of using Euler angles is mainly that they are prone to [Gimbal lock](https://en.wikipedia.org/wiki/Gimbal_lock), something that some may have experienced in plain MTA already. Slipe allows you to get and set rotations using Quaternions if desired.

#### Matrices
The [Matrix3x2](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.matrix3x2?view=netframework-4.7.2) and [Matrix4x4](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.matrix4x4?view=netframework-4.7.2) together with their complexe method definitions are integrated in Slipe. Matrices are useful algebraic tools to calculate positional, rotational and scale properties in one data structure. All [Physical Elements]([https://mta-slipe.com/api/shared/Slipe.Shared.Elements.PhysicalElement.html](https://mta-slipe.com/api/shared/Slipe.Shared.Elements.PhysicalElement.html)) allow you to get and set their matrix.

## Timers
To conform to C# convention, the timer elements in MTA are implemented under the [System.Timers](https://docs.microsoft.com/en-us/dotnet/api/system.timers?view=netframework-4.7.2) namespace. The namespace provides the [Timer](https://docs.microsoft.com/en-us/dotnet/api/system.timers.timer?view=netframework-4.7.2) component, which allows you to raise an event on a specified interval.
```csharp
using System.Timers;

private int c;

static void Main(string[] args)
{
	c = 0;
	
	// Create a timer and set a two second interval.
	Timer aTimer = new Timer(2000);
	
	// Hook up the Elapsed event for the timer.
	aTimer.Elapsed += OnTimedEvent;
	
	// Start the timer 
	aTimer.Enabled = true;
}

public static void OnTimedEvent(Object source, ElapsedEventArgs e)
{
	c++;	
	Console.WriteLine("The elapsed event was raised at " + e.SignalTime.ToString());

	// If the event was elapsed 5 times, stop the timer
	if(c >= 5)
	{
		Timer t = (Timer)source;
		t.Enabled = false;
	}
}


```

## System.IO.File
Handling files is implemented using a subset of methods from [System.IO.File](https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=netframework-4.7.2). The opening and closing of files is handled by Slipe so you don't have to worry about memory leaks. The methods are:

 - [ReadAllBytes(String)](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readallbytes?view=netframework-4.7.2#System_IO_File_ReadAllBytes_System_String_)
 - [ReadAllText(String)](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalltext?view=netframework-4.7.2#System_IO_File_ReadAllText_System_String_)
 - [ReadAllLines(String)](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalllines?view=netframework-4.7.2#System_IO_File_ReadAllLines_System_String_)
 - [WriteAllBytes(String, Byte[])](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.writeallbytes?view=netframework-4.7.2#System_IO_File_WriteAllBytes_System_String_System_Byte___)
 - [WriteAllText(String, String)](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.writealltext?view=netframework-4.7.2#System_IO_File_WriteAllText_System_String_System_String_)
 - [WriteAllLines(String, String[])](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.writealllines?view=netframework-4.7.2#System_IO_File_WriteAllLines_System_String_System_String___)
 - [Exists(String)](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.exists?view=netframework-4.7.2#System_IO_File_Exists_System_String_)
 - [Delete(String)](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.delete?view=netframework-4.7.2#System_IO_File_Delete_System_String_)
 - [Copy(String, String, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.copy?view=netframework-4.7.2#System_IO_File_Copy_System_String_System_String_System_Boolean_)

## System.Console
To output information to the client or server console, use the [System.Console](https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netframework-4.7.2) class. Currently, the following methods are implemented:

 - [Write(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.console.write?view=netframework-4.7.2#System_Console_Write_System_Object_)
 - [WriteLine(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.7.2#System_Console_WriteLine_System_Object_)

## System.Diagnostics.Debug
Output information to the MTA debug section using the [System.Diagnostics.Debug](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.debug?view=netframework-4.7.2) class. Supported methods are:

 - [Write(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.debug.write?view=netframework-4.7.2#System_Diagnostics_Debug_Write_System_Object_)
 - [WriteIf(Boolean, Object)](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.debug.writeif?view=netframework-4.7.2#System_Diagnostics_Debug_WriteIf_System_Boolean_System_Object_)
 - [WriteLine(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.debug.writeline?view=netframework-4.7.2#System_Diagnostics_Debug_WriteLine_System_Object_)
 - [WriteLineIf(Boolean, Object)](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.debug.writelineif?view=netframework-4.7.2#System_Diagnostics_Debug_WriteLineIf_System_Boolean_System_Object_)
