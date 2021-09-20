using System;
using GildedRose.App.Events;

namespace GildedRose.App
{
    public static class ItemFactory
    {
        public static IEvent Create(Item item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            return item.Name switch
            {
                "Aged Brie" => new UpdateAgedBrieStockEvent(item),
                "Backstage passes to a TAFKAL80ETC concert" => new UpdateBackStagePassesStockEvent(item),
                "Sulfuras, Hand of Ragnaros" => new UpdateLegendaryStockEvent(item),
                "Conjured Mana Cake" => new UpdateConjuredStockEvent(item),
                _ => new UpdateStandardStockEvent(item)
            };
        }
    }
}