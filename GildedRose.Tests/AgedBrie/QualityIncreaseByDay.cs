using NUnit.Framework;

namespace GildedRose.Tests.AgedBrie
{
    [TestFixture]
    public class QualityIncreasesByDay : AndUpdateItemIsCalled
    {
        [TestCase(20, 10, 21)]
        [TestCase(21, 10, 22)]
        public void QualityShouldIncreaseEachDay(int quality, int sellIn, int expectedQuality)
        {
            ActualQualityValue = quality;
            ActualSellInValue = sellIn;

            ArrangeAndAct();
            Assert.AreEqual(expectedQuality, Item.Quality);
        }
    }
}