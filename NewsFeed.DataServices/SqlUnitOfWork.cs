using System.Configuration;
using NewsFeed.SQLDataAccess.Entities;
using NewsFeed.SQLDataAccess.Interfaces;


namespace NewsFeed.SQLDataAccess
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        #region Fields
        private SQLRepository<NewsFeedAbo> _newsFeedAbos;
        private SQLRepository<NewsFeedItem> _newsFeedItems;
        private readonly SqlContext _context;
        #endregion

        #region Construction / Initialization / Deconstruction
        public SqlUnitOfWork()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["NewsFeeds"].ConnectionString;
            _context = new SqlContext();
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
