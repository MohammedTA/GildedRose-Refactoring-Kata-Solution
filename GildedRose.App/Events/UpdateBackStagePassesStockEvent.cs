namespace GildedRose.App.Events
{
    public class UpdateBackStagePassesStockEvent : Stock
    {
        public UpdateBackStagePassesStockEvent(Item item) : base(item)
        {
        }
    }
}