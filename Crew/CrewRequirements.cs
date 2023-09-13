using RestaurantAutomation.Common;

namespace RestaurantAutomation.Crew
{
    public class CrewRequirements
    {
        public Criteria HeadChefs { get; set; }
        public Criteria RoboChefs { get; set; }
        public Criteria Technicians { get; set; }
        public Criteria Waiters { get; set; }
        public Criteria RoboWaiters { get; set; }
        public Criteria Cashiers { get; set; }
        public Criteria Janitors { get; set; }
    }
}
