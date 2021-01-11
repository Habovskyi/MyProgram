using Microsoft.EntityFrameworkCore;
using Lab6.Models;

namespace Lab6
{
    public class BDContext : DbContext
    {
        public DbSet<Hospitals> Hospitals { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Personal> Personal { get; set; }

        public BDContext(DbContextOptions<BDContext> options)
            : base(options)
        {
        }

      
    }
}