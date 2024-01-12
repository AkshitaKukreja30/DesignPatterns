This pattern's intention is to separate an abstraction from its implementation so that both can vary independently. 
This separation allows you to create a bridge between the abstraction and its implementation, making it easier to modify or extend each without affecting the other.

We have injected the refined abstraction AdvancedRemoteControl into the Client class to call the actual Implementations 
Client interacts with refined abstraction AdvancedRemoteControl instead of Implemenation

Without DI, this can be achieved this way in ClientController:

 IDevice tv = new TV();

// Creating instances of refined abstractions
RemoteControl basicRemoteForTV = new BasicRemoteControl(tv);

// Using remote controls to operate devices
basicRemoteForTV.TurnOn();