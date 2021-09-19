using System;
using Microsoft.Extensions.DependencyInjection;

namespace GildedRose.App
{
    public class Program
    {
        private static IServiceProvider ServiceProvider => Helper.ConfigureServices().BuildServiceProvider();
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            var items = SeedData.GetItems();
            var app = new GildedRose(ServiceProvider);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");

                foreach (var item in items)
                {
                    Console.WriteLine(item);
                    app.UpdateQuality(item);
                }
                Console.WriteLine("");
            }
        }
    }
}