using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GenericRepository.EntityFramework;
using TestApp.Entities;
using TestApp.Repositories.IRepositories;

namespace TestApp.Repositories
{
    public class ProductRepository : BaseRepository<Product, int>, IProductRepository
    {
        public ProductRepository(IEntitiesContext dbContext) : base(dbContext)
        {

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}