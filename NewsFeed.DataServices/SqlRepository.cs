using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NewsFeed.SQLDataAccess.Entities;
using NewsFeed.SQLDataAccess.Interfaces;

namespace NewsFeed.SQLDataAccess
{
    public class SQLRepository<T> : IRepository<T> where T : class
    {
        #region Fields
        private readonly DbSet _objectSet;
        #endregion

        #region Construction / Initialization / Deconstruction
        public SQLRepository(SqlContext context)
        {
            _objectSet = context.Set<T>();
        }
        #endregion

        #region Public implementations
        public void Add(T entity)
        {
            _objectSet.Add(entity);
        }

        public T Find(int id)
        {
            return (T)_objectSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _objectSet.Cast<T>().ToList();
        }

        public void Remove(T entity)
        {
            _objectSet.Remove(entity);
        }
        #endregion
    }
}
