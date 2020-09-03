using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8.BlazorWebApi.Entities
{
    public class DataContext : DbContext
    { 

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

       public DbSet<Customer> Customers { get; set; }
    }
}
