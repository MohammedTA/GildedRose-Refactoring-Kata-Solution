using GildedRose.App.Events;

namespace GildedRose.App.Handlers
{
    public class StandardHasUpdateEventHandler : IHasUpdateHandler<StandardUpdateEvent>
    {
        public Item Handle(StandardUpdateEvent item)
        {
            item.SellIn--;
            if (item.Quality > 0) item.Quality--;
            if (item.SellIn < 0)
            {
                if (item.Quality > 0) item.Quality--;
            }
            return item.AdjustQuantityValue();
        }
    }
}