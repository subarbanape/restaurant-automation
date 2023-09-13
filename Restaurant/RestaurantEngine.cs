using RestaurantAutomation.Billing;
using RestaurantAutomation.Equipment;
using RestaurantAutomation.Order;
using RestaurantAutomation.Septic;

namespace RestaurantAutomation.Restaurant
{
    public class RestaurantEngine
    {
        public RestaurantEngine(Restaurant restaurant) =>
            Restaurant = restaurant;

        public Restaurant Restaurant { get; }
        public SepticSystem SepticSystem { get; set; }
        public CookingEquipmentSystem CookingEquipmentSystem { get; set; }
        public ProduceInventorySystem ProduceInventorySystem { get; set; }
        public BillingSystem BillingSystem { get; set; }
        public OrderManagementSystem OrderManagementSystem { get; set; }

        public RestaurantStatus Run()
        {
            return RestaurantStatus.Running;
        }
    }
}
