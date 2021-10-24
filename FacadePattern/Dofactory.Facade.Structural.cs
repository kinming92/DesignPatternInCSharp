using System;

namespace Dofactory.Facade.Structural
{
    /// <summary>
    /// subsytem classA
    /// </summary>
    public class SubSystemOne
    {
        public void MehtodOne()
        {
            Console.WriteLine(" SubSystemOne Method");
        }
    }

    public class SubSystemTwo
    {
        public void MehtodTwo()
        {
            Console.WriteLine(" SubSystemTwo Method");
        }
    }
    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine(" SubsystemThree Method");
        }
    }
    public class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine(" SubSystemFour Method");
        }
    }

    /// <summary>
    /// The Facade class
    /// </summary>
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() --- ");
            one.MehtodOne();
            two.MehtodTwo();
            three.MethodThree();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() --- ");
            two.MehtodTwo();
            three.MethodThree();
        }
    }
    /// <summary>
    /// Facade Design Pattern
    /// </summary>
    public class FacadeStructural
        {
            public static void Program()
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("--->Start of the FacadeStructural Program");
                Facade facade = new Facade();
                facade.MethodA();
                facade.MethodB();
                Console.WriteLine("--->End of the FacadeStructural Program");
            }
        }
}