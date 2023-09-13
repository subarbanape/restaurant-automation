using RestaurantAutomation.Beverages.Coffee;
using RestaurantAutomation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.PriceBook
{
    public abstract class PriceBook
    {
        public PriceBook(SystemInfo systemInfo) 
        {
            this.systemInfo = systemInfo;
        }

        public int Id { get; }
        public string Name { get; }

        SystemInfo systemInfo { get; }

        public Dictionary<string, Price> Prices { get; }
        protected void add(string name, Price price)
        {
            Prices.Add(name, price);
        }

        public abstract void Init();
    }
}
