# RPCs
An RPC (Remote procedure call) is the Slipe representation of server to client & client to server communication.  

RPCs are sent and received through the `RpcManager` ([Server documentation](/api/server/Slipe.Server.Rpc.RpcManager.html), [Client documentation](/api/server/Slipe.Client.Rpc.RpcManager.html))

RPCs work somewhat similar to how client & server events do in MTA, where you will register a function to be called when an RPC is triggered.


## RPC payload classes
In an RPC you can send a single object / instance of a class (or enum) along with any trigger. This means you will have to define a class to encapsulate the values you want to tarnsmit from server to client, or the other way around.

An RPC payload is split up into two classes, one "incoming" class, and one "outgoing" class. Where the outgoing class will send the data, and the incoming class will parse the data.

Here's an example:
```cs
public class BasicOutgoingRpc : IRpc
{
    // the fields to transmit
    public string name;
    public int x;
    public MtaElement element;

    
    // the constructor which sets the fields
    public BasicOutgoingRpc(string name, int x, Element element)
    {
        this.name = name;
        this.x = x;
        this.element = element.MTAElement;
    }
}
```

```cs
public class BasicIncomingRpc : IRpc
{
    public string name;
    public int x;
    public Element element;

    // Parsing the single `dynamic` vlaue to the proper type fields
    public BasicIncomingRpc(dynamic value)
    {
        this.x = (int)value.x;
        this.name = (string)value.name;
        this.element = Slipe.Shared.Elements.ElementManager.Instance.GetElement(value.element);
    }
}
```
It is import that you cast the data in `value` to the appropriate types when using incoming RPCs. Because when transferring over the network all metatable data (which class / datatype something is) is lost.

## Registering an RPC
In order to register an RPC you have to call the `RegisterRPC` method on the singleton `Instance` of the `RpcManager`. The `RegisterRPC` method is a generic method, meaning you need to supply a type argument, this type argument is the `IncomingRpc` type you wish to receive.
```cs
RpcManager.Instance.RegisterRPC<BasicIncomingRpc>("testRPC", HandleTestRPC);

public void HandleTestRPC(BasicIncomingRpc arguments)
{
    Debug.WriteLine("Handling testRPC, name: {0}, x: {1}, player name: {2}", arguments.name, arguments.x, ((Player)arguments.element).Name);
}
```

## Triggering an RPC
Trigger RPCs is quite easy. You use the `TriggerRpc` method on the `RpcManager`.

Client:
```cs
RpcManager.Instance.TriggerRPC("onPlayerReady", new EmptyOutgoingRpc());
```

Server:
```cs
// send to a specific player
Player nano = (Player)Player.GetFromName("SAES>Nanobob");
RpcManager.Instance.TriggerRPC(nano, "testRPC", new BasicOutgoingRpc("Vehicle damage", (int)loss, nano));

// send to everyone
RpcManager.Instance.TriggerRPC(Element.Root, "testRPC", new BasicOutgoingRpc("Vehicle damage", (int)loss, nano));
```