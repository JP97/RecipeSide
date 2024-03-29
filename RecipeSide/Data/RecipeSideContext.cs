﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeSide.Models;

namespace RecipeSide.Models
{
    public class RecipeSideContext : DbContext
    {
        public RecipeSideContext (DbContextOptions<RecipeSideContext> options)
            : base(options)
        {
        }

        public DbSet<RecipeSide.Models.Ingredient> Ingredient { get; set; }

        public DbSet<RecipeSide.Models.Recipe> Recipe { get; set; }
    }
}
