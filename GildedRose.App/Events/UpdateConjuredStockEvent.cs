namespace GildedRose.App.Events
{
    public class UpdateConjuredStockEvent : Stock
    {
        public UpdateConjuredStockEvent(Item item) : base(item)
        {
        }
    }
}