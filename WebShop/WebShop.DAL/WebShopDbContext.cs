using Microsoft.EntityFrameworkCore;
using System;
using WebShop.Model;

namespace Vjezba.DAL
{
    public class WebShopDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        protected WebShopDbContext() { }
        public WebShopDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    Id = 1,
                    Name = "Monitor 1",
                    Description = "Monitor 1 description",
                    MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    Price = 2000.5
                },
                new Item
                {
                    Id = 2,
                    Name = "Monitor 2",
                    Description = "Monitor 2 description",
                    MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    Price = 2500.5
                },
                new Item
                {
                    Id = 3,
                    Name = "Monitor 3",
                    Description = "Monitor 3 description",
                    MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    Price = 1060.5
                },
                new Item
                {
                    Id = 4,
                    Name = "Monitor 4",
                    Description = "Monitor 4 description",
                    MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    Price = 1006.5
                },
                new Item
                {
                    Id = 5,
                    Name = "Monitor 5",
                    Description = "Monitor 5 description",
                    MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    Price = 5000.5
                },
                new Item
                {
                    Id = 6,
                    Name = "Monitor 6",
                    Description = "Monitor 6 description",
                    MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    Price = 1020.5
                },
                new Item
                {
                    Id = 7,
                    Name = "Monitor 7",
                    Description = "Monitor 7 description",
                    MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    Price = 220.5
                }
            );
            modelBuilder.Entity<Tag>()
                .HasData(
                   new Tag
                   {
                       Id = 1,
                       Description = "Monitor"
                   },
                   new Tag
                   {
                       Id = 2,
                       Description = "Graphics card"
                   }
               );
        }
    }
}
