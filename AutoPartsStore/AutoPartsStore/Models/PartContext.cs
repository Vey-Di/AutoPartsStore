﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
    public class PartContext : IdentityDbContext
    {
        public DbSet<Part> Parts { get; set; }
        public PartContext( DbContextOptions<PartContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
