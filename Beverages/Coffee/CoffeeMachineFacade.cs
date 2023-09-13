using RestaurantAutomation.Billing;
using RestaurantAutomation.Utils;

namespace RestaurantAutomation.Beverages.Coffee
{
    public static class CoffeeMachineFacade
    {
        static string[] names = { "Brewie Nelson", "The Daily Grind", "Java the Hutt",
                                  "The Drippi", "Morning Melody", "Mocha Lisa"  };

        public static CoffeeMachine[] Create(int quantity)
        {
            var priceBook = new BeveragesPriceBook(new BillingSystemInfo());
            priceBook.Init();

            new Random().Shuffle(names);
            return Enumerable
             .Range(1, quantity)
             .Select(index => new CoffeeMachine(names[index-1], new Random().Next(1, 10), ))
             .ToArray();
        }
    }

   
}
