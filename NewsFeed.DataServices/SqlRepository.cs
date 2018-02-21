using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NewsKeeper.Logging;
using NewsKeeper.SQLDataAccess.Entities;
using NewsKeeper.SQLDataAccess.Interfaces;

namespace NewsKeeper.SQLDataAccess
{
    public sealed class SQLRepository<T> : LogBase, IRepository<T> where T : BaseEntity
    {
        #region Fields

        private readonly SqlContext _context;
        private readonly DbSet _objectSet;
        #endregion

        #region Construction / Initialization / Deconstruction
        public SQLRepository(SqlContext context)
        {
            _context = context;
            _objectSet = context.Set<T>();
            Debug(@"Constructor SQLRepository(SqlContext context).");
        }
        #endregion

        #region Public implementations
        public void Add(T entity)
        {
            _objectSet.Add(entity);
        }

        public void Update(T entity)
        {
            var updateEntity = (T)_objectSet.Find(entity.Id);
            if (updateEntity != null)
            {
                _context.Entry(updateEntity).CurrentValues.SetValues(entity);
            }
        }

        public T Find(int id)
        {
            return (T)_objectSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _objectSet.Cast<T>().OrderByDescending(c => c.CreationDate).ToList();
        }

        public void Remove(T entity)
        {
            _objectSet.Remove(entity);
        }
        #endregion
    }
}
