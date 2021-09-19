namespace GildedRose.App.Events
{
    public class LegendaryUpdateEvent : Item, IHasUpdateEvent
    {
        public LegendaryUpdateEvent(Item item)
        {
            Name = item.Name;
            Quality = item.Quality;
            SellIn = item.SellIn;
        }
    }
}