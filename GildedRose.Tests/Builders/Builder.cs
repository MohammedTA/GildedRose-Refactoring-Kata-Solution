using System;
using GildedRose.App.Events;

namespace GildedRose.Tests.Builders
{
    public abstract class Builder<TBuilderType, TBuildType>
    {
        public abstract IEvent AnInstance();

        public static TBuilderType Build => Activator.CreateInstance<TBuilderType>();
    }
}