using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GenericRepository;
using GenericRepository.EntityFramework;

namespace TestApp.Repositories
{
    public abstract class BaseRepository<T, TId> : EntityRepository<T, TId>
        where T : class, IEntity<TId>
        where TId : IComparable
    {


        private bool _isCacheEnable = true;

        protected BaseRepository(IEntitiesContext dbContext) : base(dbContext)
        {

        }

        public bool IsCacheEnable
        {
            get { return _isCacheEnable; }
            set { _isCacheEnable = value; }
        }
        private int _cacheMinute = 30;
        public int CacheMinute
        {
            get { return _cacheMinute; }
            set { _cacheMinute = value; }
        }
       
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                  
                }
            }
            this.disposed = true;
        }

    }
}