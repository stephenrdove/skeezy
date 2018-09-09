using System;
using Microsoft.EntityFrameworkCore;
using Skeezy.Models;

namespace Skeezy.Data 
{ 
    public class ApplicationDbContext : DbContext
    {
      public ApplicationDbContext(DbContextOptions options) : base(options)
      {
      }

        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
    }
}




