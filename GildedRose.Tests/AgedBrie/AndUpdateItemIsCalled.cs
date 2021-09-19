using GildedRose.App.Events;
using GildedRose.App.Handlers;
using GildedRose.Tests.Builders;

namespace GildedRose.Tests.AgedBrie
{
    public class AndUpdateItemIsCalled : WhenTestingHandler<AgedBrieUpdateEvent>
    {
        protected override void Setup()
        {
            Item = (AgedBrieUpdateEvent)ItemBuilder
                .Build
                .With("Aged Brie", ActualSellInValue, ActualQualityValue)
                .AnInstance();

            Handler = new AgedBrieHasUpdateEventHandler();
        }
    }
}