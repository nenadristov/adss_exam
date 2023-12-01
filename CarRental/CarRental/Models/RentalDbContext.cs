using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CarRental.Models
{
    public class RentalDbContext : DbContext
    {
       
            public RentalDbContext(DbContextOptions<RentalDbContext> options) : base(options)
            {
            }
            public DbSet<Car> Car { get; set; }
            public DbSet<Client> Client { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Car>();
                modelBuilder.Entity<Client>();

            base.OnModelCreating(modelBuilder);
            }
        }
    }
