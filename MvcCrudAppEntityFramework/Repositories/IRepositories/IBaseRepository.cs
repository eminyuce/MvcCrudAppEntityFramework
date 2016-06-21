using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GenericRepository;
using GenericRepository.EntityFramework;

namespace TestApp.Repositories.IRepositories
{
    public interface IBaseRepository<T, TId> : IEntityRepository<T, TId>
        where T : class, IEntity<TId>
        where TId : IComparable
    {
    }
}