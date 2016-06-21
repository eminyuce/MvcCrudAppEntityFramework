using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestApp.Entities;

namespace TestApp.Repositories.IRepositories
{
    public interface IProductDbContext
    {
        DbSet<Product> Products { get; set; }
    }
}