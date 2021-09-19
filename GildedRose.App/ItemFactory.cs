using System;
using GildedRose.App.Events;

namespace GildedRose.App
{
    public static class ItemFactory
    {
        public static Item Create(Item item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            return item.Name switch
            {
                "Aged Brie" => new AgedBrieUpdateEvent(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackStagePassesUpdateEvent(item),
                "Sulfuras, Hand of Ragnaros" => new LegendaryUpdateEvent(item),
                "Conjured Mana Cake" => new ConjuredUpdateEvent(item),
                _ => new StandardUpdateEvent(item)
            };
        }
    }
}