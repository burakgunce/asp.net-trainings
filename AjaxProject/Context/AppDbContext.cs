using AjaxProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AjaxProject.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person()
                {
                    Id = 1,
                    FirstName = "aaa",
                    LastName = "bbb",
                    Age = 10,
                    BirthDate = new DateTime(2001,08,12)
                },
                new Person()
                {
                    Id = 2,
                    FirstName = "ccc",
                    LastName = "ddd",
                    Age = 14,
                    BirthDate = new DateTime(2006,06,16)
                }

                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
