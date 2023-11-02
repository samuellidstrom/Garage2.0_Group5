﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garage2._0_Group5.Models;

namespace Garage2._0_Group5.Data
{
    public class Garage2_0_Group5Context : DbContext
    {
        public Garage2_0_Group5Context (DbContextOptions<Garage2_0_Group5Context> options)
            : base(options)
        {
        }

        public DbSet<Garage2._0_Group5.Models.Vehicle> Vehicle { get; set; } = default!;
    }
}
