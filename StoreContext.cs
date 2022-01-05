using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Store_Management.Models
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions options)
           : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryViewModel> Category { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }
}
