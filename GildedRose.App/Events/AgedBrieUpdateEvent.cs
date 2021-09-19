namespace GildedRose.App.Events
{
    public class AgedBrieUpdateEvent : Item, IHasUpdateEvent
    {
        public AgedBrieUpdateEvent(Item item)
        {
            Name = item.Name;
            Quality = item.Quality;
            SellIn = item.SellIn;
        }
    }
}