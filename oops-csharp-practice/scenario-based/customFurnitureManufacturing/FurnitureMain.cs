using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.customFurnitureManufacturing
{
    internal class FurnitureMain
    {
        public static void Main(string[] args)
        {
            InputService input = new InputService();
            WoodRod rod = input.TakeInput();

            // Scenario A
            ICutStrategy revenueOnly = new RevenueMaxStrategy();
            revenueOnly.SuggestCuts(rod);

            // Scenario B & C
            Console.Write("\nEnter allowed waste (ft): ");
            int wasteLimit = int.Parse(Console.ReadLine());

            ICutStrategy wasteAware = new WasteAwareStrategy(wasteLimit);
            wasteAware.SuggestCuts(rod);
        }
    }

}

