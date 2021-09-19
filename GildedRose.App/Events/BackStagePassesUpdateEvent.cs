namespace GildedRose.App.Events
{
    public class BackStagePassesUpdateEvent : Item, IHasUpdateEvent
    {
        public BackStagePassesUpdateEvent(Item item)
        {
            Name = item.Name;
            Quality = item.Quality;
            SellIn = item.SellIn;
        }
    }
}