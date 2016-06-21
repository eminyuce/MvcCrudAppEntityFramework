using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GenericRepository.EntityFramework;
using TestApp.Entities;
using TestApp.Repositories.IRepositories;

namespace TestApp.Repositories
{
    public class ProductDbContext : EntitiesContext, IProductDbContext
    {

        public ProductDbContext(String nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            this.Database.CommandTimeout = int.MaxValue;
        }

        public DbSet<Product> Products { get; set; }
    }
}