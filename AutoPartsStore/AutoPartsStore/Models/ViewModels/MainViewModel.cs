using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models.ViewModels
{
    public class MainViewModel :IdentityUser
    {
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IfNewUser { get; set; }
        public string ReturnUrl { get; set; }

    }
}
