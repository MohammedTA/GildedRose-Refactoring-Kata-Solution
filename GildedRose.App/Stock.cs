using GildedRose.App.Events;

namespace GildedRose.App
{
    public abstract class Stock : IEvent
    {
        public Stock(Item context)
        {
            Item = context;
        }

        public Item Item { get; }

        public override string ToString()
        {
            return $"{Item.Name}, {Item.SellIn}, {Item.Quality}";
        }
    }
}