using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApp.Entities;

namespace TestApp.Repositories.IRepositories
{
    public interface IProductRepository : IBaseRepository<Product, int>,  IDisposable 
    {
    }
}