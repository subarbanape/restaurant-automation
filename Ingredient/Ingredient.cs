using RestaurantAutomation.Common;
using RestaurantAutomation.PriceBook;

namespace RestaurantAutomation.Ingredient
{
    public class Ingredient : ISellable
    {
        public Ingredient(int id, string name, Price price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; }
        public string Name { get; }
        public Price Price { get; }
    }
}
