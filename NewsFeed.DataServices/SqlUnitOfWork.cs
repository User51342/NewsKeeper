using NewsKeeper.SQLDataAccess.Interfaces;
using NewsKeeper.Logging;
using NewsKeeper.SQLDataAccess.Entities;

namespace NewsKeeper.SQLDataAccess
{
    public sealed class SqlUnitOfWork : LogBase, IUnitOfWork
    {
        #region Fields
        private SQLRepository<NewsFeedAbo> _newsFeedAbos;
        private SQLRepository<NewsFeedItem> _newsFeedItems;
        private readonly SqlContext _context;
        #endregion

        #region Construction / Initialization / Deconstruction
        public SqlUnitOfWork() 
        {
            _context = new SqlContext();
            Debug("Constructor SqlUnitOfWork().");
        }
        #endregion

        #region Properties

        public SQLRepository<NewsFeedAbo> NewsFeedAbos
        {
            get
            {
                if (_newsFeedAbos == null)
                {
                    _newsFeedAbos = new SQLRepository<NewsFeedAbo>(_context);
                }

                return _newsFeedAbos;
            }
        }

        public SQLRepository<NewsFeedItem> NewsFeedItems
        {
            get
            {
                if (_newsFeedItems == null)
                {
                    _newsFeedItems = new SQLRepository<NewsFeedItem>(_context);
                }

                return _newsFeedItems;
            }
        }
        #endregion
        
        #region Public implementation
        public void commit()
        {
            _context.SaveChanges();
        }
        #endregion
    }
}
