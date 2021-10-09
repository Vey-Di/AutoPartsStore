using AutoPartsStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Incorrect Phone number")]
        public string ContactPhone { get; set; }

        public string Cart { get; set; }

        public string UserName { get; set; }

        [NotMapped]
        public Cart VisualCart { get; set; }
    }
}
