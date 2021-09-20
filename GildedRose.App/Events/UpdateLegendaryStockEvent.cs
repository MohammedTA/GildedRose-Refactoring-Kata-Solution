namespace GildedRose.App.Events
{
    public class UpdateLegendaryStockEvent : Stock
    {
        public UpdateLegendaryStockEvent(Item item) : base(item)
        {
        }
    }
}