using GildedRose.App.Events;

namespace GildedRose.App.Handlers
{
    public class UpdateStandardHasStockEventHandler : IEventHandler<UpdateStandardStockEvent>
    {
        public Item Handle(UpdateStandardStockEvent stock)
        {
            stock.Item.SellIn--;
            stock.Item.Quality--;
            if (stock.Item.SellIn < 0)
            {
                stock.Item.Quality--;
            }
            return stock.Item.AdjustQuantityValue();
        }
    }
}