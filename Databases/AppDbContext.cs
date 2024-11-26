using System.Configuration;
using GarageApp.Model;
using Microsoft.EntityFrameworkCore;


namespace GarageApp.Databases
{
    internal class AppDbContext : DbContext
    {
        
        public DbSet<Personenauto> Personenautos { get; set; } = null!;
        public DbSet<Onderdeel> Onderdelen { get; set; } = null!;
        public DbSet<AutoOnderdeel> AutoOnderdelen { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {

                string connstr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                optionsBuilder.UseMySQL(connstr);
            }
        }
    }
}