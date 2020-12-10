using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Contexts
{
    public class CityInfoContext: DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointOfInterest { get; set; }
        public CityInfoContext(DbContextOptions<CityInfoContext> options): base(options)
        {
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park"
                },
                 new City()
                 {
                     Id = 2,
                     Name = "Gdańsk",
                     Description = "The two"
                 },
                  new City()
                  {
                      Id = 3,
                      Name = "Cracow",
                      Description = "The three"
                  }
                );
            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                    new PointOfInterest()
                    {
                        Id = 1,
                        CityId = 1,
                        Name = "Name 1",
                        Description = "Description 1"
                    },
                    new PointOfInterest()
                    {
                        Id = 2,
                        CityId = 1,
                        Name = "Name 2",
                        Description = "Description 2"
                    },
                    new PointOfInterest()
                    {
                        Id = 3,
                        CityId = 2,
                        Name = "Name 3",
                        Description = "Description 3"
                    },
                    new PointOfInterest()
                    {
                        Id = 4,
                        CityId = 2,
                        Name = "Name 4",
                        Description = "Description 4"
                    },
                    new PointOfInterest()
                    {
                        Id = 5,
                        CityId = 3,
                        Name = "Name 5",
                        Description = "Description 3"
                    },
                    new PointOfInterest()
                    {
                        Id = 6,
                        CityId = 3,
                        Name = "Name 6",
                        Description = "Description 6"
                    }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
