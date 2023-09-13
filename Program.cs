// See https://aka.ms/new-console-template for more information
using RestaurantAutomation.Beverages.Coffee;
using RestaurantAutomation.Common;
using RestaurantAutomation.Crew;
using RestaurantAutomation.Restaurant;

Console.WriteLine("Hello, World!");

RunCoffeeMachine();


var name = "PixelSoup";
var crewRequirements = new CrewRequirements
                        {
                            Cashiers = Criteria.Create(),
                            HeadChefs = Criteria.Create(),
                            Janitors = Criteria.Create(5),
                            RoboChefs = Criteria.Create(2),
                            RoboWaiters = Criteria.Create(5),
                            Waiters = Criteria.Create(10),
                            Technicians = Criteria.Create(5),
                        };

var restaurant = new RestaurantBuilder()
                    .Create(name)
                    .SetCrewRequirements(crewRequirements)
                    .Build();

var restaurantEngine = new RestaurantEngine(restaurant).Run();


if (restaurant.Status == RestaurantStatus.Running)
{
    Console.WriteLine($"Restaurant {restaurant.Name}:{restaurant.Id} successfully instantiated.");
}
else
{
    Console.WriteLine($"Restaurant {restaurant.Name}:{restaurant.Id} creation failed. Status: {restaurant.Status}");
}



void RunCoffeeMachines()
{
    var coffeeMachines = CoffeeMachineFacade.Create(2);
}