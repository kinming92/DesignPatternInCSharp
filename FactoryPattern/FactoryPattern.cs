using FactoryPattern.General;
using FactoryPattern.RealWorld;
using FactoryPattern.CreditCard;
using FactoryPattern.CreditCard2;

namespace FactoryPattern
{
    class FactoryPattern
    {
        static void Main(string[] args)
        {
            FactoryMethodGeneral.Program();
            FactoryMethodRealWorld.Program();
            FactoryPatternCreditCard.Program();
            FactoryPatternCreditCard2.Program();
        }
    }
}