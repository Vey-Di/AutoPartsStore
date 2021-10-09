using Newtonsoft.Json;
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
                        Quantity = 40,
                        Feature = JsonConvert.SerializeObject(new List<Feature>
                    {
                        new Feature{Name = "CaseMaterial", Value="Plastic"}
                    }),
                        Image = "0",
                        Price = 79
                    },
                    new Part
                    {
                        Title = "Radiator",
                        Quantity = 40,
                        Feature = JsonConvert.SerializeObject(new List<Feature>
                    {
                        new Feature{Name = "CaseMaterial", Value="Plastic"}
                    }),
                        Image = "0",
                        Price = 110
                    },
                    new Part
                    {
                        Title = "Engine Oil",
                        Quantity = 5,
                        Feature = JsonConvert.SerializeObject(new List<Feature>
                    {
                        new Feature{Name = "CaseMaterial", Value="Plastic"}
                    }),
                        Image = "0",
                        Price = 400
                    },
                    new Part
                    {
                        Title = "Coolant",
                        Quantity = 19,
                        Feature = JsonConvert.SerializeObject(new List<Feature>
                    {
                        new Feature{Name = "CaseMaterial", Value="Plastic"}
                    }),
                        Image = "0",
                        Price = 490
                    },
                    new Part
                    {
                        Title = "Battery",
                        Quantity = 48,
                        Feature = JsonConvert.SerializeObject(new List<Feature>
                    {
                        new Feature{Name = "CaseMaterial", Value="Plastic"}
                    }),
                        Image = "0",
                        Price = 1100
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}
