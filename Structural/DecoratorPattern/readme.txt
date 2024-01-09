Decorator is a structural design pattern that lets you attach new behaviors to objects

Example:
Wearing clothes is an example of using decorators. When you’re cold, you wrap yourself in a sweater.
If you’re still cold with a sweater, you can wear a jacket on top. If it’s raining, you can put on a raincoat. 
All of these garments “extend” your basic behavior but aren’t part of you, and you can easily take off any piece of clothing whenever you don’t need it.

Use case:
Start with basic. If needed, keep extending the behavior and create more concrete Decorator classes.

Structure:

Interface: IComponent
BaseComponent Class AKA Concrete Component implementing basic functionalities of IComponent
Decorator1 implementing IComponent further extending the functionality
Decorator2 implementing IComponent further extending the functionality