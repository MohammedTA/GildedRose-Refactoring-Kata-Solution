using System.Collections.Generic;
using GildedRose.App.Events;

namespace GildedRose.App
{
    public static class SeedData
    {
        public static IList<IEvent> GetItems()
        {
            return new List<IEvent>
            {
                ItemFactory.Create(new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 }),
                ItemFactory.Create(new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 }),
                ItemFactory.Create(new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 }),
                ItemFactory.Create(new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 }),
                ItemFactory.Create(new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 }),
                ItemFactory.Create(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                }),
                ItemFactory.Create(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                }),
                ItemFactory.Create(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                }),
                // this conjured item does not work properly yet
                ItemFactory.Create(new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 })
            };
        }
    }
}