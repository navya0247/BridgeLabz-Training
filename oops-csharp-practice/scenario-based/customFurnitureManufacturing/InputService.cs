using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.customFurnitureManufacturing
{
    internal class InputService
    {
       public WoodRod TakeInput()
        {
            Console.Write("Enter rod length (ft): ");
            int length = int.Parse(Console.ReadLine());

            WoodRod rod = new WoodRod(length);

            Console.WriteLine("Enter price for each length:");
            for (int i = 1; i <= length; i++)
            {
                Console.Write("Price of " + i + " ft: ");
                rod.Prices[i] = int.Parse(Console.ReadLine());
            }

            return rod;
        }
    }

}

