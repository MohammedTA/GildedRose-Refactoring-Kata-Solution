using System;
using System.Collections.Generic;
using GildedRose.App.Events;

namespace GildedRose.App
{
    public class GildedRose
    {
        private readonly Dictionary<Type, Func<IHasUpdateEvent, Item>> handlers;
        public GildedRose(IServiceProvider serviceProvider)
        {
            handlers = Helper.GetHandlers(serviceProvider);
        }

        public void UpdateQuality(Item item)
        {
            if (!handlers.TryGetValue(item.GetType(), out var handler))
                throw new ArgumentOutOfRangeException(nameof(item));
            handler(item as IHasUpdateEvent);
        }
    }
}