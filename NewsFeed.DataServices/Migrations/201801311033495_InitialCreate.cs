namespace NewsFeed.SQLDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewsFeedAbos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeedName = c.String(),
                        Description = c.String(),
                        FeedUrl = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NewsFeedItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewsFeedItem");
            DropTable("dbo.NewsFeedAbos");
        }
    }
}
