# SOLID
#### 📚 This is just a summary of what I've been reviewing about SOLID. You can find more content in the book *Agile Principles, Patterns, and Practives in C#*.

### SRP - Single Responsibility Principle
A class should have one, and only one, reason to change. In the context of the SRP, we define a responsibility to be a reason for change. If you can think of more than one motive for changing a class, that class has more than one responsibility.

### OCP - Open Closed Principle
Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification. When a single change to a program results in a cascade of changes to dependent modules, the design smells of rigidity. OCP advises us to refactor the system so that further changes of that kind will not cause more modifications. If OCP is applied well, further changes of that kind are achieved by adding new code, not by changing old code that already works. **The principle idea is the extension of main functionality to other second functionalities**.

### LSP - Liskov Substitution Principle
Subtypes must be Subtitutable for their base types. The Open/Closed Principle is at the heart of many of the claims made for object-oriented design. When this principle is in effect, applications are more maintainable, reusable, and robust. The Liskov Substitution Principle is one of the prime enablers of OCP. The substitutability of subtypes allows a module, expressed in terms of a base type, to be extensible without modification. That substitutability must be something that developers can depend on implicitly. Thus, the contract of the
base type has to be well and prominently understood, if not explicitly enforced, by the code. **The term IS-A is too broad to act as a definition of a subtype**. The true definition of a subtype is **substitutable**, where substitutability is defined by either an explicit or implicit contract.
Here we must think about what the main class should really provide in common for all other subclasses

### ISP - Interface Segregation Principle
This principle deals with the disadvantages of "fat" interfaces. Classes whose interfaces are not cohesive have "fat" interfaces. In other words, the interfaces of the class can be broken up into groups of methods. Each group serves a different set of clients. Thus, some clients use one group of methods, and other clients use the other groups. **Clients should not be forced to depend on methods they do not use**.

### DIP - The Dependency-Inversion Principle
A somewhat more naive, yet still very powerful, interpretation of DIP is the simple heuristic: "Depend on abstractions." Simply stated, this heuristic recommends that you should not depend on a concrete class and that rather, all relationships in a program should terminate on an abstract class or an interface.

Ajuste
Novo Ajuste
Novo teste agora vai
Novo teste 18/06
