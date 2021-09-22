using System;

namespace FactoryPattern
{
    /// <summary>
    /// Entry point to console application
    // </summary>
    class MainApp
    {
        static void Main(string[] args)
        {
           // An array of creators
           Creator[] creators = new Creator[2];
           creators[0] = new ConcreteCreatorA();
           creators[1] = new ConcreteCreatorB();

           // Iterate over creators and create products

           foreach (Creator creator in creators)
           {
               Product product = creator.FactorMethod();
               Console.WriteLine($"Created {product.GetType().Name}");

               // Wait for use
               Console.ReadKey();
           }
        }

        /// <summary>
        /// The Product abstract class
        /// </summary>

        abstract class Product
        {
        }

        /// <summary>
        /// The ConcreteProduct class
        /// </summary>
        class ConcreteProductA: Product
        {
        }

        /// <summary>
        /// A concreteProduct class
        /// </summary>
        class ConcreteProdcutB : Product 
        {
        }

        /// <summary>
        /// A concreteCreator class
        /// </summary>
        class ConcreteCreatorA: Creator
        {
            public override Product FactoryMethod()
            {
                return new ConcreteProductA();
            }
        }


        /// <summary>
        /// A 'ConcreteCreator' class
        /// </summary>
        class ConcreteCreatorB : Creator
        {
            public override Product FactoryMethod()
            {
                return new ConcreteProductB();
            }
        }
        
    }
}
