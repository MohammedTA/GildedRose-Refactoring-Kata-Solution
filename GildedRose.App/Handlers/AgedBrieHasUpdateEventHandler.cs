using GildedRose.App.Events;

namespace GildedRose.App.Handlers
{
    public class AgedBrieHasUpdateEventHandler : IHasUpdateHandler<AgedBrieUpdateEvent>
    {
        public Item Handle(AgedBrieUpdateEvent item)
        {
            item.SellIn--;
            if (item.Quality < 50) item.Quality++;
            if(item.SellIn < 0) item.Quality++;
            return item.AdjustQuantityValue();
        }
    }
}