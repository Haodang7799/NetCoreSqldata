using Microsoft.EntityFrameworkCore;
using PracticeTutorial1.Configurations;
using PracticeTutorial1.Extentions;
using PracticeTutorial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTutorial1.Data
{
    public class ToturialDBContext : DbContext
    {
        public ToturialDBContext(DbContextOptions<ToturialDBContext> options)
            : base(options)
        { 
 
        }
        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            // configura database
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new LoginUserConfiguration());
            base.OnModelCreating(modelBuilder);
            //seed data base
            modelBuilder.Seed();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
    }
}
