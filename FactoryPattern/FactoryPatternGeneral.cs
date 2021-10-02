using System;

namespace FactoryPattern.General
{
    /// <summary>
    /// Entry point to console application
    /// https://www.dofactory.com/net/factory-method-design-pattern
    /// </summary>
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
               Product product = creator.FactoryMethod();
               Console.WriteLine($"Created {product.GetType().Name}");

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
        class ConcreteProductB : Product 
        {
        }

        /// <summary>
        /// The 'Creator' abstract class
        /// </summary>
        abstract class Creator
        {
            public abstract Product FactoryMethod();
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
