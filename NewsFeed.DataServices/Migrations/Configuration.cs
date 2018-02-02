using System.Data.Entity.Migrations;
using NewsKeeper.SQLDataAccess.Entities;

namespace NewsKeeper.SQLDataAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SqlContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "NewsFeed.SQLDataAccess.Entities.SqlContext";
        }

        protected override void Seed(SqlContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

        }
    }
}
