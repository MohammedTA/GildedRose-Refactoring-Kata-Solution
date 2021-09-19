using GildedRose.App.Events;

namespace GildedRose.App.Handlers
{
    public class LegendaryHasUpdateEventHandler : IHasUpdateHandler<LegendaryUpdateEvent>
    {
        public Item Handle(LegendaryUpdateEvent item)
        {
            item.SellIn = item.SellIn;
            item.Quality = item.Quality;
            return item;
        }
    }
}