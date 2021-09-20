using GildedRose.App.Events;

namespace GildedRose.App.Handlers
{
    public class UpdateConjuredHasStockEventHandler : IEventHandler<UpdateConjuredStockEvent>
    {
        public Item Handle(UpdateConjuredStockEvent stock)
        {
            stock.Item.SellIn--;
            stock.Item.Quality -= 2;
            if (stock.Item.SellIn < 0)
            {
                stock.Item.Quality -= 2;
            }
            return stock.Item.AdjustQuantityValue();
        }
    }
}