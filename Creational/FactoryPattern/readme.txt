The Factory Pattern is a design pattern used to create objects. Instead of directly instantiating objects using the new keyword in your code, you use a "factory" class or method to create those objects. This helps you delegate the creation process, making your code more flexible and easier to maintain.

Key Idea:
The Factory is responsible for creating objects, and your code asks the factory for an object without knowing exactly how it’s created.
This pattern hides the object creation details from the client (i.e., the code that uses the objects).
Real-World Analogy:
Think of a pizza restaurant:

When you want a pizza, you don't make it yourself. Instead, you ask the restaurant (factory) for a pizza.
The restaurant (factory) knows how to make different kinds of pizzas (cheese pizza, pepperoni pizza, veggie pizza) based on your order.
You don’t need to know the steps to prepare the pizza; you just receive the ready pizza.
Similarly, in software, instead of creating objects directly, you ask a factory to provide you with the object.


Here, we inject IDeviceFactory in the Client class.
DeviceFactory is the concrete creator class that further decides which obj to create and how 