using GildedRose.App.Events;

namespace GildedRose.App.Handlers
{
    public class UpdateBackStagePassesHasStockEventHandler : IEventHandler<UpdateBackStagePassesStockEvent>
    {
        public Item Handle(UpdateBackStagePassesStockEvent stock)
        {
            stock.Item.SellIn--;

            if (stock.Item.Quality < 50) stock.Item.Quality++;

            if (stock.Item.SellIn < 10)
            {
                stock.Item.Quality++;
            }
            if (stock.Item.SellIn < 5)
            {
                stock.Item.Quality++;
            }
            if (stock.Item.SellIn < 0)
            {
                stock.Item.Quality = 0;
            }

            return stock.Item.AdjustQuantityValue();
        }
    }
}