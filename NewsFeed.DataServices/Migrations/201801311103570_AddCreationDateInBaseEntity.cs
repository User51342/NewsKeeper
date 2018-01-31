namespace NewsFeed.SQLDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreationDateInBaseEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewsFeedAbos", "CreationDate", c => c.DateTime(defaultValueSql: "GETDATE()"));
            AddColumn("dbo.NewsFeedItem", "CreationDate", c => c.DateTime(defaultValueSql: "GETDATE()"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewsFeedItem", "CreationDate");
            DropColumn("dbo.NewsFeedAbos", "CreationDate");
        }
    }
}
