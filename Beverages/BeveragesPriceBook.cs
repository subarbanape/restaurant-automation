using RestaurantAutomation.Beverages.Coffee;
using RestaurantAutomation.Common;
using RestaurantAutomation.PriceBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Beverages
{
    public class BeveragesPriceBook : PriceBook.PriceBook
    {
        public BeveragesPriceBook(SystemInfo systemInfo):base(systemInfo) { }

        public override void Init()
        {
            // tbd: fetch the price book from price server
            add(typeof(CoffeeBase).FullName, new Price(0.5M));
            add(typeof(EspressoBase).FullName, new Price(0.6M));
            add(typeof(EspressoBase).FullName, new Price(0.6M));
        }
    }
}
