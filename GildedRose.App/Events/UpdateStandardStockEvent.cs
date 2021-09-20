namespace GildedRose.App.Events
{
    public class UpdateStandardStockEvent : Stock
    {
        public UpdateStandardStockEvent(Item item) : base(item)
        {
        }
    }
}