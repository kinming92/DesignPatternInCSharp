using System;

namespace FactoryPattern.CreditCard
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

    public class Platinum : CreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }

        public int GetAnnualCharge()
        {
            return 2000;
        }
    }

    public class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 2500;
        }
    }

    public class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }

    public class StudentCreditCard : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 0;
        }

        public string GetCardType()
        {
            return "Student";
        }

        public int GetCreditLimit()
        {
            return 4000;
        }
    }

    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();

        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }

    public class MoneyBackFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new MoneyBack();
            return product;
        }
    }

    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }

    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Titanium();
            return product;
        }
    }

    public class StudentCreditCardFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new StudentCreditCard();
            return product;
        }
    }

    public static class FactoryPatternCreditCard
    {
        public static void Program()
        {
            CreditCard creditCardObj = new PlatinumFactory().CreateProduct();
            if(creditCardObj != null)
            {
                Console.WriteLine($"Card Type : {creditCardObj.GetCardType()}");
                Console.WriteLine($"Credit Limit : {creditCardObj.GetCreditLimit()}");
                Console.WriteLine($"Annual Change : {creditCardObj.GetAnnualCharge()}");
            }
            else
            {
                Console.WriteLine("Invalid credit card");
            }
            
            CreditCard creditCardObj2 = new StudentCreditCardFactory().CreateProduct();
            if(creditCardObj2 != null)
            {
                Console.WriteLine($"Card Type : {creditCardObj2.GetCardType()}");
                Console.WriteLine($"Credit Limit : {creditCardObj2.GetCreditLimit()}");
                Console.WriteLine($"Annual Change : {creditCardObj2.GetAnnualCharge()}");
            }
            else
            {
                Console.WriteLine("Invalid credit card");
            }
        }
    }

}