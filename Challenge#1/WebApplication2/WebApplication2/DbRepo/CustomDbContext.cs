using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.DbRepo
{
    class CustomDbContext : DbContext
    {
        public CustomDbContext() :
            base("name=CustomConnectionString")
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}