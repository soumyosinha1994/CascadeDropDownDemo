using CascadeDropDownDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CascadeDropDownDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(new Country { CountryName = "India", Id = 1 });

            modelBuilder.Entity<State>().HasData(new State { Id = 1, StateName = "West Bengal", CountryId = 1 },
                new State { Id = 2, StateName = "Jharkhand", CountryId = 1 });

            modelBuilder.Entity<City>().HasData(new City { Id = 1, CityName = "Kolkata", StateId = 1 },
                new City { Id = 2, CityName = "Jamshedpur", StateId = 2 });
        }
    }
}
