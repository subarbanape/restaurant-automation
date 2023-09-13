namespace RestaurantAutomation.Beverages.Coffee
{
    public class CoffeeMachine
    {
        public string Name { get; }
        public int Id { get; }
        Mixer[] mixers;
        public PriceBook.PriceBook PriceBook { get; }

        public CoffeeMachine(string name, int mixersCount, PriceBook.PriceBook priceBook)
        {
            Name = name;
            mixers = new Mixer[mixersCount];
            PriceBook = priceBook;
        }

        Mixer getMixer() { return mixers.FirstOrDefault(item => item.Status == MixerStatus.Available); }
    }

    class Mixer
    {
        public MixerStatus Status { get; }
    }

    enum MixerStatus
    { 
        Broken = 0,
        Available = 1,
        Occupied = 2,
    }
}
