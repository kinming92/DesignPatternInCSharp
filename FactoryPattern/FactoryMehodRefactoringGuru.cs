using System;
namespace FactoryPattern.RefactoringGuru
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Creator: The same creator's code has just worked with " + product.Operation();
            return result;
        }
    }

    class ConcreteCreator1 : Creator
    {
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
    
    public interface IProduct
    {
        string Operation();
    }

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

         private void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I am not aware of the creator's class but it still works.");
            Console.WriteLine(creator.SomeOperation());
        }
    }

   
}