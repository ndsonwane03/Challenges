using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DbRepo
{
    public class CustomerRepository
    {
        public IEnumerable<Customer> GetAll()
        {
            using (var dbContext = new CustomDbContext())
            {
                return dbContext.Customers.ToList();
            }
        }

        public void Create(Customer customer)
        {
            using (var dbContext = new CustomDbContext())
            {
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
            }
        }
    }
}