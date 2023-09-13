using RestaurantAutomation.Common;

namespace RestaurantAutomation.Restaurant
{
    public class Restaurant
    {
        public Restaurant(
            string name, int id,
            SetupInfo setupInfo,
            Crew.Crew[] crews,
            RestaurantStatus status)
        {
            Name = name;
            Id = id;
            SetupInfo = setupInfo;
            Crews = crews;
            Status = status;
        }

        public string Name { get; private set; }
        public int Id { get; }
        public RestaurantStatus Status { get; }
        public Crew.Crew[] Crews { get; }
        public SetupInfo SetupInfo { get; }

    }
}
