using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.customFurnitureManufacturing
{   
        // Scenario A: Choose cut giving maximum earnings
        class RevenueMaxStrategy : ICutStrategy
        {
            public void SuggestCuts(WoodRod rod)
            {
                int bestRevenue = 0;
                int bestCut = rod.TotalLength;

                for (int cut = 1; cut <= rod.TotalLength; cut++)
                {
                    int pieces = rod.TotalLength / cut;
                    int revenue = pieces * rod.Prices[cut];

                    if (revenue > bestRevenue)
                    {
                        bestRevenue = revenue;
                        bestCut = cut;
                    }
                }

                Console.WriteLine("Best cut size: " + bestCut + " ft");
                Console.WriteLine("Maximum revenue: " + bestRevenue);
            }
        }

    }

