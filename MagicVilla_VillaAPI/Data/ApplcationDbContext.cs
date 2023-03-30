using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplcationDbContext : DbContext
    {

        public ApplcationDbContext(DbContextOptions<ApplcationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; } //Villas will be my Table in SQL
        public DbSet<VillaNumber> VillaNumber { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal villa",
                    Details = "Sem detalhes",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 100,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
