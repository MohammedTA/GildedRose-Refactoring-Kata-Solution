using GildedRose.App.Events;

namespace GildedRose.App.Handlers
{
    public class ConjuredHasUpdateEventHandler : IHasUpdateHandler<ConjuredUpdateEvent>
    {
        public Item Handle(ConjuredUpdateEvent item)
        {
            item.SellIn--;
            if (item.Quality > 0) item.Quality -= 2;
            if (item.SellIn < 0)
            {
                if (item.Quality > 0) item.Quality -= 2;
            }
            return item.AdjustQuantityValue();
        }
    }
}