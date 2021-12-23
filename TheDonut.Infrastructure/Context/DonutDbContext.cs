using Microsoft.EntityFrameworkCore;
using TheDonut.Domain.Entities;

namespace TheDonut.Infrastructure.Context
{
    public class DonutDbContext : DbContext
    {
        public DonutDbContext(DbContextOptions<DonutDbContext> options)
            : base(options) { }

        public DbSet<Donut> Donut { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Donut>().HasData(new Donut { Id = 1, Name = "Chocolate Belga", Price = 8.50 });
            modelBuilder.Entity<Donut>().HasData(new Donut { Id = 2, Name = "Chocolate Branco", Price = 7.50 });
            modelBuilder.Entity<Donut>().HasData(new Donut { Id = 3, Name = "Frutas Vermelhas", Price = 6.50 });
        }
    }
}