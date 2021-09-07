using AutoPartsStore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
