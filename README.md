# DesignPatternInCSharp

### Example to build all solution
```
dotnet build [specific project folder]
```
### Example to run the individual solution
```
dotnet run --project FactoryMethod
``` 
### Progress
##### Date: 9/21/2021
- I get started by setting up with C# in VS Code
- I failed to build the project
- I am not able to set up the comment session in omnisharp

#### Date: 10/1/2021
- I created a general and realworld factory design pattern class
- I need to figure out namespace, the main method issue, and how to build different namespace

#### Date: 10/2/2021
- I learned the concept of provided and required interface
- A provided interface is an interface that describes (the services) that instances of a classifier(supplier) offers to their clients
- A required interface is an interface that is defined by the (client of an interaction) that (specifies what a supplier component needs to do) so that the required interface(it) can be used in that interaction.
- I created basic UML diagram in draw.io
- ###### Reference
    - [Provided and Required Interface](https://ducmanhphan.github.io/2020-01-27-The-different-types-of-Interfaces-in-UML-diagrams/#definition-of-interface-in-diagram)
    - [Ball and Socket notation by MartinFowler](https://martinfowler.com/bliki/BallAndSocket.html)
    - [UML Diagram](https://www.uml-diagrams.org/interface.html)


#### Date: 10/10/2021
- Definition of Factory Method: Define an interface for creating an object, but let the subclasses decide which class to instantiate. The Factory method lets a class defer instantiation it uses to subclasses
- Solved the Main method issue that two static main method exists in the main app program.
- Learned FactoryPattern With CreditCard as an example.

#### Date: 10/14/2021
- I updated the drawio diagram
- I got a better understanding of the usage of Factory Design Pattern that there is a Product and a Creator

#### Date: 10/15/2021
- I renamed the refactoring guru files and I added comments on the FactoryMethod.Conceptual.cs
- I revised and relearned adapter design pattern.

#### Date 10/16/2021
- I updated the folder/project solution structure.
- I added a new global Design Pattern solution for this project.
- I added a new AdapaterPattern console application for the project solution.
- I added the SquarePegAndRoundHole example, and learned C# setter and getter syntax.

#### Date: 10/23/2021
- I reworked the SquarePegAndRoundHoles.cs. I did not understand the use of public in constructor solve the inaccesiblities issue when we create a new obj with the constructor in line 142 and line 143. Apparently, the program wanted to make the constructor public explicitly.

### Reference
 - [csharpcorner](https://www.c-sharpcorner.com/article/factory-method-design-pattern-in-c-sharp/)
 - [dofactory](https://www.dofactory.com/net/factory-method-design-pattern)
 - [RefactoringGuru](https://refactoring.guru/design-patterns)