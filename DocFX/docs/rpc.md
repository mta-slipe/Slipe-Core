# RPCs
An RPC (Remote procedure call) is the Slipe representation of server to client & client to server communication.  

RPCs are sent and received through the `RpcManager` ([Server documentation](/api/server/Slipe.Server.Rpc.RpcManager.html), [Client documentation](/api/server/Slipe.Client.Rpc.RpcManager.html))

RPCs work somewhat similar to how client & server events do in MTA, where you will register a function to be called when an RPC is triggered.


## RPC payload classes
In an RPC you can send a single object / instance of a class (or enum) along with any trigger. This means you will have to define a class to encapsulate the values you want to transmit from server to client, or the other way around.

An RPC payload is a simple class which implements the `IRpc` interface. 
Any RPC payload class will have 3 methods:
* A (parameterless) default constructor  
  This constructor is used internally, when it's missing Visual Studio will show an error
* A constructor for passing in data  
  This is the constructor used by your code to populate the RPC payload (this is optional)
* A Parse method
  This is the method which parses a single Lua table value back to the payload class

Here's an example:
```cs
public class ElementRpc: BaseRpc
{
    public Element Element { get; set; }

    public ElementRpc()
    {

    }

    public ElementRpc(Element element)
    {
        this.Element = element;
    }

    public override void Parse(dynamic value)
    {
        this.Element = GetElement<Element>(value.Element);
    }
}
```
It is import that you cast the data in `value` to the appropriate types when using incoming RPCs. Because when transferring over the network all metatable data (which class / datatype something is) is lost.  
The abstract `BaseRpc` class has several methods to make this process easier.

## Registering an RPC
In order to register an RPC you have to call the `RegisterRPC` method on the singleton `Instance` of the `RpcManager`. The `RegisterRPC` method is a generic method, meaning you need to supply a type argument, this type argument is the `IRpc` payload class type you wish to receive.
```cs
RpcManager.Instance.RegisterRPC<ElementRpc>("announce", HandleAnnouncement);

public void HandleAnnouncement(Player player, ElementRpc rpc)
{
    ChatBox.WriteLine(rpc.Element.Type);
}
```

## Triggering an RPC
Trigger RPCs is quite easy. You use the `TriggerRpc` method on the `RpcManager`.

Client:
```cs
RpcManager.Instance.TriggerRPC("announce", new ElementRpc(Player.Local));
```

Server:
```cs
// send to a specific player
Player nano = (Player)Player.GetFromName("SAES>Nanobob");
RpcManager.Instance.TriggerRPC(nano, "testRPC", new ElementRpc(someElement));

// send to everyone
RpcManager.Instance.TriggerRPC(Element.Root, "testRPC", new ElementRpc(someElement));
```

## Async RPCs
Async RPCs allow you to return a value over an RPC, and use `async / await` in order to use it. You will no longer need to bounce RPCs back and forth to get a value from the server to the client or vice versa.

Example:
Server:
```cs
RpcManager.Instance.RegisterAsyncRPC<SingleCastRpc<string>, EmptyRpc>("Async.RequestMapName", (player, request) =>
{
    return new SingleCastRpc<string>(GameServer.Announcement.MapName);
});
```
Client:
```cs
Task.Run(async () =>
{
    string name = (await RpcManager.Instance.TriggerAsyncRpc<SingleCastRpc<string>>("Async.RequestMapName", new EmptyRpc())).Value;
    ChatBox.WriteLine($"Map name: {name}");
});
``