using RefactoringGuru.DesignPatterns.Facade.Conceptual;
using Dofactory.Facade.Structural;
using Restaurant.Facade;
namespace FacadePattern
{
    class FacadePattern
    {
        static void Main(string[] args)
        {
            RefactoringGuru.DesignPatterns.Facade.Conceptual.Facade.FacadeConceptual.Program();
            FacadeStructural.Program();
            RestaurantFacadeClientCode.Program();

        }
    }
}
