using Microsoft.EntityFrameworkCore;
using StraxServiceDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StraxServiceDetails.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<ServiceCategory> ServiceCategories { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
