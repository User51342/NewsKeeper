using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewsFeed.SQLDataAccess;
using NewsFeed.SQLDataAccess.Entities;


namespace NewsFeed.Tests
{
    [TestClass]
    public class SQLTests
    {
        [TestMethod]
        public void InsertIntoNewsFeedAbo()
        {
            var unitOfWork = new SqlUnitOfWork();
            unitOfWork.NewsFeedAbos.Add(new NewsFeedAbo() { FeedName = "Erster", FeedUrl = @"http://www.google.de", IsActive = true });
            unitOfWork.commit();
        }
    }
}
