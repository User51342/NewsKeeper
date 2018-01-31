using System.Data.Entity;

namespace NewsFeed.SQLDataAccess.Entities
{
    public class SqlContext : DbContext
    {
        // Your context has been configured to use a 'DataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'NewsFeed.DataServices.NewsFeeds' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'NewsFeeds' 
        // connection string in the application configuration file.
        public SqlContext() : base("name=NewsFeeds")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<NewsFeedAbo> NewsFeedAbos { get; set; }
        public virtual DbSet<NewsFeedItem> NewsFeedItems { get; set; }
    }
}