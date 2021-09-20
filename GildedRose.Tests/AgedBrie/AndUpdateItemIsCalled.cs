using GildedRose.App.Events;
using GildedRose.App.Handlers;
using GildedRose.Tests.Builders;

namespace GildedRose.Tests.AgedBrie
{
    public class AndUpdateItemIsCalled : WhenTestingHandler<UpdateAgedBrieStockEvent>
    {
        protected override void Setup()
        {
            Item = (UpdateAgedBrieStockEvent)ItemBuilder
                .Build
                .With("Aged Brie", ActualSellInValue, ActualQualityValue)
                .AnInstance();

            Handler = new UpdateAgedBrieHasStockEventHandler();
        }
    }
}