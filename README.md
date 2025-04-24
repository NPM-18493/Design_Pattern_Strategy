# Strategy Design Pattern

### Type
Behavioral Design Pattern

### What problem it solves?
Strategy Design Pattern avoids tight coupling between systems. Algorithm can be replaced at runtime. No need to put if else logic while executing specific logic based on conditions.

### How it solves the problem?
It Defines a family of algorithms. Encapsulates each algorithm in a separate class. Makes the algorithms interchangeable by using a common interface. In our example, we have passed algorithm implementing class instance to the parent class where Car's break logic is executed.

### Limitations
+ Not ideal for project where algorithms do not change frequently.
+ Adds complexity due to multiple strategy classes

### Diagram
![strategy_pattern drawio](https://github.com/user-attachments/assets/0cf22c8a-9597-486b-b0dc-c8b729f7fd2d)

