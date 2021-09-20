using GildedRose.App.Events;

namespace GildedRose.App.Handlers
{
    public class UpdateAgedBrieHasStockEventHandler : IEventHandler<UpdateAgedBrieStockEvent>
    {
        public Item Handle(UpdateAgedBrieStockEvent stock)
        {
            stock.Item.SellIn--;
            if (stock.Item.SellIn < 0)
            {
                stock.Item.Quality += 2;
            }
            else
            {
                stock.Item.Quality += 1;
            }
            return stock.Item.AdjustQuantityValue();
        }
    }
}