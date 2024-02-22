using CheckStatus.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace CheckStatus.Api.Data
{
    public class CheckStatusDbContext:DbContext
    {
        public CheckStatusDbContext(DbContextOptions<CheckStatusDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SiteStatus>().HasData(new SiteStatus
            {
                Id = 1,
                SiteName = "Georgetown",
                IsOnline = true,
                IpAddress = "127.0.0.1",

            }); ;
            modelBuilder.Entity<SiteStatus>().HasData(new SiteStatus
            {
                Id = 2,
                SiteName = "Nicholasville",
                IsOnline = true,
                IpAddress = "127.0.0.1",

            });
            modelBuilder.Entity<SiteStatus>().HasData(new SiteStatus
            {
                Id = 3,
                SiteName = "Louisville",
                IsOnline = true,
                IpAddress = "127.0.0.1",

            });
        }

        public DbSet<SiteStatus> SiteStatuses { get; set; }

    }
}

