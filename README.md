# SOLID

### SRP - Single Responsibility Principle
A class should have one, and only one, reason to change. In the context of the SRP, we define a responsibility to be a reason for change. If you can think of more than one motive for changing a class, that class has more than one responsibility.

### OCP - Open Closed Principle
Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification. When a single change to a program results in a cascade of changes to dependent modules, the design smells of rigidity. OCP advises us to refactor the system so that further changes of that kind will not cause more modifications. If OCP is applied well, further changes of that kind are achieved by adding new code, not by changing old code that already works. **The principle idea is the extension of main functionality to other second functionalities**.
