using GildedRose.App;
using GildedRose.App.Events;

namespace GildedRose.Tests.Builders
{
    public class ItemBuilder : Builder<ItemBuilder, Item>
    {
        private string itemName = "+5 Dexterity Vest";
        private int sellInValue = 20;
        private int qualityValue = 20;

        public override IEvent AnInstance()
        {
            return ItemFactory.Create(new Item
            {
                Name = itemName,
                SellIn = sellInValue,
                Quality = qualityValue
            });
        }

        public ItemBuilder With(string name, int sellIn, int quality)
        {
            itemName = name;
            qualityValue = quality;
            sellInValue = sellIn;
            return this;
        }
    }
}