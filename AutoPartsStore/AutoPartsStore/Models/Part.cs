using AutoPartsStore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
    public class Part
    {
        public int PartId { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string Feature { get; set; }

        [NotMapped]
        public List<Feature> VisualFeature { get; set; }

        [Required]
        public string Image { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
