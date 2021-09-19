using GildedRose.App.Events;

namespace GildedRose.App.Handlers
{
    public class BackStagePassesHasUpdateEventHandler : IHasUpdateHandler<BackStagePassesUpdateEvent>
    {
        public Item Handle(BackStagePassesUpdateEvent item)
        {
            item.SellIn--;

            if (item.Quality < 50) item.Quality++;

            if (item.SellIn < 10)
            {
                if (item.Quality < 50) item.Quality++;
            }
            if (item.SellIn < 5)
            {
                if (item.Quality < 50) item.Quality++;
            }
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }

            return item.AdjustQuantityValue();
        }
    }
}