using System;

namespace FactoryPattern.CreditCard2
{

    #region Product
    ///<summary>
    ///The Product Abstract Class
    ///<summary/>
    ///

    abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }

    #endregion
    
    #region Concrete Product 
    class MoneyBackCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "MoneyBack";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType
        {
            get 
            {
                return _cardType;
            }
        }

        public override int CreditLimit
        {
            get
            {
                return _creditLimit;
            }
            set
            {
                _creditLimit = value;
            }
        }
        
        public override int AnnualCharge
        {
            get
            {
                return _annualCharge;
            }
            set
            {
                _annualCharge = value;
            }
        }
    }

    class TitaniumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Titanium";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType
        {
            get 
            {
                return _cardType;
            }
        }

        public override int CreditLimit
        {
            get
            {
                return _creditLimit;
            }
            set
            {
                _creditLimit = value;
            }
        }
        
        public override int AnnualCharge
        {
            get
            {
                return _annualCharge;
            }
            set
            {
                _annualCharge = value;
            }
        }
    }

    class PlatinumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Platinum";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType
        {
            get 
            {
                return _cardType;
            }
        }

        public override int CreditLimit
        {
            get
            {
                return _creditLimit;
            }
            set
            {
                _creditLimit = value;
            }
        }
        
        public override int AnnualCharge
        {
            get
            {
                return _annualCharge;
            }
            set
            {
                _annualCharge = value;
            }
        }
    }

    #endregion

    #region Creator 

    /// <summary>  
    /// The 'Creator' Abstract Class  
    /// </summary>  
    abstract class CardFactory  
    {  
        public abstract CreditCard GetCreditCard();  
    }  

    #endregion

    #region ConcreteCreator
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>  
    class MoneyBackFactory : CardFactory  
    {  
        private int _creditLimit;  
        private int _annualCharge;  
  
        public MoneyBackFactory(int creditLimit, int annualCharge)  
        {  
            _creditLimit = creditLimit;  
            _annualCharge = annualCharge;  
        }  
  
        public override CreditCard GetCreditCard()  
        {  
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);  
        }  
    }  

    class TitaniumFactory: CardFactory      
    {      
        private int _creditLimit;      
        private int _annualCharge;      
      
        public TitaniumFactory(int creditLimit, int annualCharge)      
        {      
            _creditLimit = creditLimit;      
            _annualCharge = annualCharge;      
        }      
      
        public override CreditCard GetCreditCard()      
        {      
            return new TitaniumCreditCard(_creditLimit, _annualCharge);      
        }      
    }      

    class PlatinumFactory: CardFactory      
    {      
        private int _creditLimit;      
        private int _annualCharge;      
      
        public PlatinumFactory(int creditLimit, int annualCharge)      
        {      
            _creditLimit = creditLimit;      
            _annualCharge = annualCharge;      
        }      
      
        public override CreditCard GetCreditCard()      
        {      
            return new PlatinumCreditCard(_creditLimit, _annualCharge);      
        }      
    }      

    #endregion

    #region Demo

    public class FactoryPatternCreditCard2
    {
        public static void Program()
        {
            CardFactory factory = null;  
            Console.Write("Enter the card type you would like to visit: ");  
            string car = Console.ReadLine();  
  
            switch (car.ToLower())  
            {  
                case "moneyback":  
                    factory = new MoneyBackFactory(50000, 0);  
                    break;  
                case "titanium":  
                    factory = new TitaniumFactory(100000, 500);  
                    break;  
                case "platinum":  
                    factory = new PlatinumFactory(500000, 1000);  
                    break;  
                default:  
                    break;  
            }  
  
            CreditCard creditCard = factory.GetCreditCard();  
            Console.WriteLine("\nYour card details are below : \n");  
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",  
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge); 
        }
    }

    #endregion
}