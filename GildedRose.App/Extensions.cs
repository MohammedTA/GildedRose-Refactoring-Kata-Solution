namespace GildedRose.App
{
    public static class Extensions
    {
        /// <summary>
        /// Adjust quantity value for specific <see cref="Item"/> after the updating process,
        /// the quantity value should be between 0 to 50
        /// </summary>
        /// <param name="item">The item to be adjusted</param>
        /// <returns></returns>
        public static Item AdjustQuantityValue(this Item item)
        {
            if (item.Quality > 50)
                item.Quality = 50;
            if (item.Quality < 0)
                item.Quality = 0;
            return item;
        }
    }
}