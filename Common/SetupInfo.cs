using RestaurantAutomation.Billing;
using RestaurantAutomation.Crew;
using RestaurantAutomation.Equipment;
using RestaurantAutomation.Order;
using RestaurantAutomation.Produce;
using RestaurantAutomation.Septic;

namespace RestaurantAutomation.Common
{
    public class SetupInfo
    {
        public SetupInfo(
                CrewRequirements crewRequirements,
                BillingSystemInfo billingServerInfo,
                SepticSystemInfo septicServerInfo,
                EquipmentInventorySystemInfo equipmentInventoryServerInfo,
                ProduceInventorySystemInfo produceInventoryServerInfo)
        {
            
        }
        public CrewRequirements CrewRequirements { get; }
        public BillingSystemInfo BillingServerInfo { get; }
        public SepticSystemInfo SepticServerInfo { get; }
        public EquipmentInventorySystemInfo EquipmentInventoryServerInfo { get; }
        public ProduceInventorySystemInfo ProduceInventoryServerInfo { get; }
        public OrderManagementSystem OrderManagementSystemInfo { get; }
    }
}
