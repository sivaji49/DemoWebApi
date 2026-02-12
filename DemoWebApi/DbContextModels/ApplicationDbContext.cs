using EEMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
namespace EEMS.DbContextModels
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasNoKey();
            modelBuilder.Entity<Role>().HasNoKey();
            modelBuilder.Entity<Department>().HasNoKey();
            modelBuilder.Entity<Document>().HasNoKey();


        }

    }
}
