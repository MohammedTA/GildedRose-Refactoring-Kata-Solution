using GildedRose.App;
using GildedRose.App.Events;
using GildedRose.App.Handlers;
using GildedRose.Tests.Builders;

namespace GildedRose.Tests
{
    public class WhenTestingHandler<TEvent> where TEvent : Item, IHasUpdateEvent
    {
        protected IHasUpdateHandler<TEvent> Handler { get; set; }
        protected TEvent Item { get; set; }

        protected int ActualQualityValue { get; set; }
        protected int ActualSellInValue { get; set; }
        protected int ExpectedQualityValue { get; set; }
        protected int ExpectedSellInValue { get; set; }

        protected virtual void Setup()
        {
            Item = (TEvent)ItemBuilder
                .Build
                .AnInstance();
        }

        protected void ArrangeAndAct()
        {
            Setup();
            Handler.Handle(Item);
        }
    }
}