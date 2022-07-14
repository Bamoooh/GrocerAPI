using Microsoft.EntityFrameworkCore;
using GrocerAPI.Models;

namespace GrocerAPI.DbSettings
{
    public class ApplicationDbContext : DbContext
    {
        //constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Market> Markets { get; set; }
        public DbSet<Grocery> Groceries { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<FamilyMember> FamilyMembers { get; set; }
    }
}