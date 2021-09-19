namespace GildedRose.App.Events
{
    public class ConjuredUpdateEvent : Item, IHasUpdateEvent
    {
        public ConjuredUpdateEvent(Item item)
        {
            Name = item.Name;
            Quality = item.Quality;
            SellIn = item.SellIn;
        }
    }
}