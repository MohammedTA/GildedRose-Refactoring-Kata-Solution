namespace GildedRose.App.Events
{
    public class StandardUpdateEvent : Item, IHasUpdateEvent
    {
        public StandardUpdateEvent(Item item)
        {
            Name = item.Name;
            Quality = item.Quality;
            SellIn = item.SellIn;
        }
    }
}