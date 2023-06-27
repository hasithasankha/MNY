using Microsoft.EntityFrameworkCore;
using MNY.Model;
using System.Collections.Generic;

namespace PMS_SYS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Drug> Drug { get; set; }

        public DbSet<Test> Test { get; set; }

    }
}
