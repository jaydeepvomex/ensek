using EnsekSolution.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EnsekSolution.WebApi
{
    /// <summary>
    /// Defines the db context used for managing database support 
    /// for the accessing the Ensek energy database.
    /// </summary>
    public class EnsekEnergyDbContext : DbContext
    {
        public EnsekEnergyDbContext(DbContextOptions<EnsekEnergyDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Gets or sets the customer accounts db sets.
        /// </summary>
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }

        /// <summary>
        /// Gets or sets the meter readings db sets.
        /// </summary>
        public DbSet<MeterReading> MeterReadings { get; set; }
    }
}
