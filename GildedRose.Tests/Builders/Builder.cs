using System;

namespace GildedRose.Tests.Builders
{
    public abstract class Builder<TBuilderType, TBuildType>
    {
        public abstract TBuildType AnInstance();

        public static TBuilderType Build => Activator.CreateInstance<TBuilderType>();
    }
}