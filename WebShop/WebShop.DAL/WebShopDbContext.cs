using Microsoft.EntityFrameworkCore;
using System;
using Vjezba.Model;

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
            modelBuilder.Entity<Item>().HasData(new Item { Id = 1, Name = "Monitor 1" });
        }
    }
}
