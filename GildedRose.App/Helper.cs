using System;
using System.Collections.Generic;
using GildedRose.App.Events;
using GildedRose.App.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace GildedRose.App
{
    public static class Helper
    {
        /// <summary>
        /// Register all event handlers
        /// </summary>
        /// <returns></returns>
        public static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();
            services.Scan(scan => scan
                .FromAssemblies(typeof(Program).Assembly)
                .AddClasses(classes => classes.AssignableTo(typeof(IHasUpdateHandler<>)))
                .AsSelfWithInterfaces()
                .WithScopedLifetime());
            return services;
        }

        public static Dictionary<Type, Func<IHasUpdateEvent, Item>> GetHandlers(IServiceProvider serviceProvider)
        {
            return new Dictionary<Type, Func<IHasUpdateEvent, Item>>
            {
                {
                    typeof(AgedBrieUpdateEvent), command => serviceProvider
                        .GetRequiredService<AgedBrieHasUpdateEventHandler>()
                        .Handle(command as AgedBrieUpdateEvent)
                },
                {
                    typeof(BackStagePassesUpdateEvent), command => serviceProvider
                        .GetRequiredService<BackStagePassesHasUpdateEventHandler>()
                        .Handle(command as BackStagePassesUpdateEvent)
                },
                {
                    typeof(ConjuredUpdateEvent), command => serviceProvider
                        .GetRequiredService<ConjuredHasUpdateEventHandler>()
                        .Handle(command as ConjuredUpdateEvent)
                },
                {
                    typeof(LegendaryUpdateEvent), command => serviceProvider
                        .GetRequiredService<LegendaryHasUpdateEventHandler>()
                        .Handle(command as LegendaryUpdateEvent)
                },
                {
                    typeof(StandardUpdateEvent), command => serviceProvider
                        .GetRequiredService<StandardHasUpdateEventHandler>()
                        .Handle(command as StandardUpdateEvent)
                }
            };
        }
    }
}