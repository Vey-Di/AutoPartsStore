
using AutoPartsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models.ViewModels
{
    public class PartShowViewModel
    {
        public int PartId { get; set; }

        public string Title { get; set; }
        public int Quantity { get; set; }
        public List<Feature> Feature { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
    }
}
