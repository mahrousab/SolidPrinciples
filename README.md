SOLID

Solid principles are sets of 5 principles and guidelines to be followed by developers that need to create good and maintainable software.

Knowing these principles is a good head start that guides you to software architectures like Domain-driven design.

Applying the solid principles to software helps you avoid things like untestable code, repeatable code, tightly coupled code, and code that can’t easily evolve.

Solid is a mnemonic acronym that stands for 5 principles in software development. These principles are:

Single Responsibility Principle Open/Closed Principle Liskov Substitution Principle Interface Segregation Principle Dependency Inversion Principle

..SRP

The single responsibility principle states that a software module (class) should only have one reason to change.

If a class is doing many things, it is not responsible for one thing and it may lead to changes every time you need to make modifications.

Classes should not be tightly coupled with other classes, this is what SRP solves.

For example, if you have a class that manages a customer and also has logging code contained in it, this class violates the SRP principle. You should rather have the logging functionality in a single class and the class should just be responsible for logging purposes and if you need to change the logging code, you can just modify only that class.

Writing code before applying SRP is also a better approach because you can just write your code and in the long run when you start feeling you are doing so many repetitions or a class is complicated, you can apply the SRP principle by breaking down this class.

..OCP

The next is the Open/Closed principle. The OCP states that a class should be open for extension but closed for modification. It is similar to the strategy design pattern 

The idea of OCP is to avoid breaking existing clients. If a class is already built and used in production, you shouldn’t modify the code, instead, you should extend the class and call the methods you need.

 ..LSP

4) The Liskov substitution principle states that subtypes must be substitutable for the base types without breaking the client code.


..ISP

The Interface Segregation Principle states that clients shouldn’t be forced to depend on methods they do not use.

For example, if you have a fat interface that contains several methods and you have a class that doesn't need some of these methods when you implement them, you can break down the interface into smaller interfaces and implement the smaller interface. But if another class needs all methods, that class can implement all interfaces that were broken down. In this way, clients are not forced to depend on methods they don’t use.

..DIP

The Dependency Inversion Principle states that High-level classes should not depend on Low-level classes. Both should depend on abstractions.

Abstractions are interfaces or abstract classes in c#.

For example, I have a high-level class that contains a complex business class. This class can be a discount class that calculates the discount on a cart item. This class should depend on abstraction, it should not depend on low-level classes like the SamsungDiscount class. Let the high-level class take a reference to the abstraction (interface) through its constructor, and the low-level class should implement the interface. You can wrap the low-level class (in this case, SamsungDiscount) into the high-level class.
5) 
