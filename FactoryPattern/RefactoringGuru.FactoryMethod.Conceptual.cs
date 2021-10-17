using System;
namespace RefactoringGuru.DesignPattterns.FactoryMethod.Conceptual
{
    // The Creator class declares the factory method that is supposed to retrun
    // an object of a Product class. The Creator's subclasses usually provide the 
    // implementation of this method.
    abstract class Creator
    {
        // Note that the creator may also provide some default implementation of
        // the factory method.
        public abstract IProduct FactoryMethod();

        // Also note that, despite its name, the Creator's primary 
        // responsibility is not creating prodicts. Usually, it contains some
        // core business logic that relies on Product objects, reutrn by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Creator: The same creator's code has just worked with " + product.Operation();
            return result;
        }
    }

    // Concrete Creators override the factory method in order to change the
    // resulting product's type
    class ConcreteCreator1 : Creator
    {
        // Note that the signature of the method still uses the abstract product 
        // type, even though the concrete priduct is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes. 
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }

    // The Product interface declares the operations that all concrete products must implement.    
    public interface IProduct
    {
        string Operation();
    }

    // Concrete Products provide various implementations of the Product interface
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "Result of Concrete Product 1";
        }    
    }

    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "Result of Concrete Product 2";
        }
    }

    public class Client
    {
        public void Program()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launced with the ConcreteCreator2");
            ClientCode(new ConcreteCreator2());
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with the 
        // creator via the base interface, you can pass it any creator's subclass.
         private void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I am not aware of the creator's class but it still works.");
            Console.WriteLine(creator.SomeOperation());
        }
    }

   
}