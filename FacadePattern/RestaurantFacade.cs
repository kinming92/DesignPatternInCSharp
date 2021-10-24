using System;
namespace Restaurant.Facade
{
    public interface IPizza
    {
        void GetVegPizza();
        void GetNonVegPizza();
    }

    /// <summary>
    /// This is a pizza provider class which will get pizza for clients
    /// </summary>
    public class PizzaProvider : IPizza 
    {
        public void GetNonVegPizza()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting Non Veg Pizza");
        }
        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza");
        }
        private void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Pizza Toppings");
        }
    }

    public interface IBread
    {
        void GetGarlicBread();
        void GetChessyGarlicBread();
    }

    public class BreadProvider : IBread
    {
        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }
        public void GetChessyGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting Cheesy Garlic Bread.");
        }
        private void GetCheese()
        {
            Console.WriteLine("Getting Cheese");
        }
    }

    public class RestaurantFacade 
    {
        private IPizza _PizzaProvider;
        private IBread _BreadProvider;
        public RestaurantFacade()
        {
            _PizzaProvider = new PizzaProvider();
            _BreadProvider = new BreadProvider();
        }
        public void GetNonVegPizza()
        {
            _PizzaProvider.GetNonVegPizza();
        }
        public void GetVegPizza()
        {
            _PizzaProvider.GetVegPizza();
        }
        public void GetGarlicBread()
        {
            _BreadProvider.GetGarlicBread();
        }
        public void GetChessyGarlicBread()
        {
            _BreadProvider.GetChessyGarlicBread();
        }
    }

    public class RestaurantFacadeClientCode
    {
        public static void Program()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("--->Start of the RestaurantFacade Program");
            Console.WriteLine("-----Client Orders for PIZZA-----");
            RestaurantFacade facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("-----Client Orders for BREADS-----");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetChessyGarlicBread();
            Console.WriteLine("--->End of the RestaurantFacade Program");
        }
    }
}