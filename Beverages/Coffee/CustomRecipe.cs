using RestaurantAutomation.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Beverages.Coffee
{
    public class CustomRecipe : Recipe.Recipe
    {
        public OrderSize Size { get; private set; } = OrderSize.Small;
        public CoffeeBase Coffee { get; private set; }
        public List<Condiment.Condiment> Condiments { get; private set; } = new List<Condiment.Condiment>();
        public List<Topping.Topping> Toppings { get; private set; } = new List<Topping.Topping>();
        public Temperature Temperature { get; private set; } = Temperature.Hot;
        public Sweetness Sweetness { get; private set; } = Sweetness.NoSugar;

        public CustomRecipe Small()
        {
            Size = OrderSize.Small;
            return this;
        }

        public CustomRecipe Medium()
        {
            Size = OrderSize.Medium;
            return this;
        }

        public CustomRecipe Large()
        {
            Size = OrderSize.Large;
            return this;
        }

        public CustomRecipe Type(CoffeeBase type)
        {
            Coffee = type;
            return this;
        }

        public CustomRecipe Condiment(Condiment.Condiment condiment)
        {
            this.Condiments.Add(condiment);
            return this;
        }

        public CustomRecipe Topping(Topping.Topping topping)
        {
            this.Toppings.Add(topping);
            return this;
        }

        public CustomRecipe Cold()
        {
            Temperature = Temperature.Cold;
            return this;
        }

        public CustomRecipe Warm()
        {
            Temperature = Temperature.Warm;
            return this;
        }

        public CustomRecipe Hot()
        {
            Temperature = Temperature.Hot;
            return this;
        }

        public CustomRecipe NoSugar()
        {
            Sweetness = Sweetness.NoSugar;
            return this;
        }

        public CustomRecipe MildSugar()
        {
            Sweetness = Sweetness.Mild;
            return this;
        }
        public CustomRecipe ModerateSugar()
        {
            Sweetness = Sweetness.Moderate;
            return this;
        }
        public CustomRecipe MoreSugar()
        {
            Sweetness = Sweetness.More;
            return this;
        }
    }
}
