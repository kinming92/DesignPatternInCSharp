using System;
namespace RefactoringGuru.DesignPattterns.Adapter.Conceptual
{
    // The Target defines the domain specific interface used by the client code.
    public interface ITarget
    {
        string GetRequest();
    }

    // The Adaptee contains some useful behavior, but its interface is 
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific Request";
        }
    }

    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public string GetRequest()
        {
            return $"This is {_adaptee.GetSpecificRequest()}";
        }
    }
    public class AdapterConceptual
    {
        public static void Program()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("--->Start of the AdapterConceptual Program");
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatiblie with the client.");
            Console.WriteLine("But with adapter client can call it's method.");
            Console.WriteLine(target.GetRequest());

             Console.WriteLine("--->End of the SquarePegAndRoundHoles Program");
        }
    }
}