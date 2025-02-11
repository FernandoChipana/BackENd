﻿

using BackEnd.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<fmedicos> FMEDICOS { get; set; }
        public DbSet<turnos> turnos { get; set; }
        public DbSet<fmclinic> fmclinic { get; set; }
        public DbSet<fespecialidad> fespecialidad { get; set; }
    }
}
