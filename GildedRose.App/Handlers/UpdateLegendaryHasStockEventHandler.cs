using GildedRose.App.Events;

namespace GildedRose.App.Handlers
{
    public class UpdateLegendaryHasStockEventHandler : IEventHandler<UpdateLegendaryStockEvent>
    {
        public Item Handle(UpdateLegendaryStockEvent stock)
        {
            stock.Item.SellIn = stock.Item.SellIn;
            stock.Item.Quality = stock.Item.Quality;
            return stock.Item;
        }
    }
}