using System;
using RefactoringGuru.DesignPattterns.Adapter.Conceptual;
using RefactoryGuru.DesignPattern.Adapter.SquarePegAndRoundHoles;

namespace AdapterPattern
{
    class AdapterPattern
    {
        static void Main(string[] args)
        {
            AdapterConceptual.Program();
            SquarePegAndRoundHoles.Program();
        }
    }
}
