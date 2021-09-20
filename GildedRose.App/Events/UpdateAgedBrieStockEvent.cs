namespace GildedRose.App.Events
{
    public class UpdateAgedBrieStockEvent : Stock
    {
        public UpdateAgedBrieStockEvent(Item context) : base(context)
        {
        }
    }
}