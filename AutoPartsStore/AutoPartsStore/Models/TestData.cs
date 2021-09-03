using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
    public class TestData
    {
        public static void Initialize (PartContext context)
        {
            if (!context.Parts.Any())
            {
                context.Parts.AddRange(
                    new Part
                    {
                        Title = "Filter",
                        Quantity = 10,
                        Price = 100
                    },
                    new Part
                    {
                        Title = "Radiator",
                        Quantity = 40,
                        Price = 110
                    },
                    new Part
                    {
                        Title = "Engine Oil",
                        Quantity = 5,
                        Price = 400
                    },
                    new Part
                    {
                        Title = "Coolant",
                        Quantity = 19,
                        Price = 490
                    },
                    new Part
                    {
                        Title = "Battery",
                        Quantity = 48,
                        Price = 1100
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}
