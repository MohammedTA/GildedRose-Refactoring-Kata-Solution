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
                .AddClasses(classes => classes.AssignableTo(typeof(IEventHandler<>)))
                .AsSelfWithInterfaces()
                .WithScopedLifetime());
            return services;
        }

        public static Dictionary<Type, Func<IEvent, Item>> GetHandlers(IServiceProvider serviceProvider)
        {
            return new Dictionary<Type, Func<IEvent, Item>>
            {
                {
                    typeof(UpdateAgedBrieStockEvent), command => serviceProvider
                        .GetRequiredService<UpdateAgedBrieHasStockEventHandler>()
                        .Handle(command as UpdateAgedBrieStockEvent)
                },
                {
                    typeof(UpdateBackStagePassesStockEvent), command => serviceProvider
                        .GetRequiredService<UpdateBackStagePassesHasStockEventHandler>()
                        .Handle(command as UpdateBackStagePassesStockEvent)
                },
                {
                    typeof(UpdateConjuredStockEvent), command => serviceProvider
                        .GetRequiredService<UpdateConjuredHasStockEventHandler>()
                        .Handle(command as UpdateConjuredStockEvent)
                },
                {
                    typeof(UpdateLegendaryStockEvent), command => serviceProvider
                        .GetRequiredService<UpdateLegendaryHasStockEventHandler>()
                        .Handle(command as UpdateLegendaryStockEvent)
                },
                {
                    typeof(UpdateStandardStockEvent), command => serviceProvider
                        .GetRequiredService<UpdateStandardHasStockEventHandler>()
                        .Handle(command as UpdateStandardStockEvent)
                }
            };
        }
    }
}