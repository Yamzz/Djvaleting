using Djvaleting.Shared.Enums;
using Djvaleting.Shared.Models;
using Djvaleting.Shared.Security;
using Microsoft.EntityFrameworkCore;

namespace Djvaleting.Server.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ValetBooking> ValetBookings { get; set; }
        public DbSet<Account> Accounts { get; set; }

        /// <summary>
        /// Seed Database with default values
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ValetBooking>().HasData(new ValetBooking
            {
                Id = 1,
                Name = "Uncle Bob",
                Flexibility= 3,
                EmailAddress = "uncle.bob@gmail.com",
                BookingDate = new DateTime(2023, 04, 25),
                ContactNumber = "999-888-7777",
                VehicleSize = VehicleSize.Large.ToString()
            }, new ValetBooking
            {
                Id = 2,
                Name = "Jan Kirsten",
                Flexibility = 1,
                EmailAddress = "jan.kirsten@gmail.com",
                BookingDate = new DateTime(2023, 05, 2),
                ContactNumber = "111-222-3333",
                VehicleSize = VehicleSize.Medium.ToString()
            });

            modelBuilder.Entity<Account>().HasData(new Account
            {
                Id = 1,
                Username = "djvalte",
                Password = Security.HashPasword("password123", out var salt),
            });
        }
    }
}
