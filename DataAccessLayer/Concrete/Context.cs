using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ProjeDb;Trusted_Connection=True;");
        }
    }
}
