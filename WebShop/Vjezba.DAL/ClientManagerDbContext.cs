using Microsoft.EntityFrameworkCore;
using System;
using Vjezba.Model;

namespace Vjezba.DAL
{
    public class ClientManagerDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        protected ClientManagerDbContext() { }
        public ClientManagerDbContext(DbContextOptions options) : base(options) { }
    }
}
