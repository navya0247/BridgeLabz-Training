using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.customFurnitureManufacturing
{
        // Scenario B & C: Revenue + Waste control
        class WasteAwareStrategy : ICutStrategy
        {
            private int allowedWaste;

            public WasteAwareStrategy(int waste)
            {
                allowedWaste = waste;
            }

            public void SuggestCuts(WoodRod rod)
            {
                int bestRevenue = 0;
                int bestCut = 0;
                int minimumWaste = rod.TotalLength;

            for (int cut = 1; cut <= rod.TotalLength; cut++)
            {
                int pieces = rod.TotalLength / cut;
                int usedLength = pieces * cut;
                int waste = rod.TotalLength - usedLength;
                int revenue = pieces * rod.Prices[cut];

                if (waste <= allowedWaste)
                {
                    if (revenue > bestRevenue || (revenue == bestRevenue && waste < minimumWaste))
                    {
                        bestRevenue = revenue;
                        bestCut = cut;
                        minimumWaste = waste;
                    }
                }
            }
                Console.WriteLine("Suggested cut size: " + bestCut + " ft");
                Console.WriteLine("Revenue: " + bestRevenue);
                Console.WriteLine("Waste: " + minimumWaste + " ft");
            }
        }

    }

