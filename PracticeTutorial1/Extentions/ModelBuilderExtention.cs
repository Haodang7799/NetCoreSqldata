using Microsoft.EntityFrameworkCore;
using PracticeTutorial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTutorial1.Extentions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product {
                    Id = 1,
                    Name = "Skin 18+",
                    Price = 492000,
                    Date = DateTime.Parse("2021-02-01"),
                    Batch = "23713" },
                 new Product
                 {
                     Id = 2,
                     Name = "Pro Sunwhite",
                     Price = 1350000,
                     Date = DateTime.Parse("2021-02-01"),
                     Batch = "LP9872"
                 },
                  new Product
                  {
                      Id = 3,
                      Name = "Manuka Gel 50ml",
                      Price = 700000,
                      Date = DateTime.Parse("2021-02-01"),
                      Batch = "46723"
                  }
            );
            modelBuilder.Entity<UserLogin>().HasData(
                 new UserLogin
                 {
                     ID = "1",
                     User = "haovippro",
                     Password = "123456"

                 },
                 new UserLogin
                 {
                     ID = "2",
                     User = "langtucodon",
                     Password = "123456"

                 }
                );
        }
    }
}
