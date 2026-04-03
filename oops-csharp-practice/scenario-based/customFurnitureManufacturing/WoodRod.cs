using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.customFurnitureManufacturing
{
    internal class WoodRod
    {
            public int TotalLength;
            public int[] Prices;

            public WoodRod(int length)
            {
                TotalLength = length;
                Prices = new int[length + 1];
            }
        }

    }

