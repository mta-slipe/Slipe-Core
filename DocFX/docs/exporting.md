# Exporting

## General exports
Slipe supports exporting static methods as MTA exports. In order to do this you use the `Export` Attribute.

```csharp
[Export("ExportSample")]
public static void DoTheThing(string x) {
    Console.WriteLine("Export has been called with parameter {0}", x);
}
```
The parameter you pass to the `Export` attribute defines the name you can call the export with. In the above example that would be
```lua
exports.slipecore:ExportSample("hey")
```
If you omit the name from the attribute the fully qualified name of the method is used, with the dots (`.`) removed. For example:
```csharp
namespace Foo
{
	public class Bar
	{
		[Export]
		public void Exporty()
		{

		}
	}
}
```

```lua
exports.slipecore:FooBarExporty()
```

When adding a new export to your project use the `-exports` option in your compile command. For example:  
`slipe compile -exports`

## Http exports
The `Export` attribute also has a boolean HTTP parameter, use this to mark a method to be HTTP callable.
```csharp
[Export("HttpCallableMethod", true)]
public void SomeMethod()
{

}
```

## Exports with element parameters
When you want to accept an element in your export parameters you need to use Slipe's `MtaElement` class, not the `Element` class. You can get the `Element` from this `MtaElement` using 
```csharp
(Slipe.Shared.Elements.Element)mtaElement;
```