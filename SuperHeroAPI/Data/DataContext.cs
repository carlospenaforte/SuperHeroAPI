﻿using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Entities;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
