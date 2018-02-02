using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewsKeeper.Grabber;
using NewsKeeper.Grabber.Parser;
using NewsKeeper.Interfaces.Entities;

namespace NewsKeeper.Tests
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void RdfParser_ShouldWork()
        {
            string testText = File.ReadAllText(".\\TestData\\rdf.xml");
            NewsFeedAboDto abo = new NewsFeedAboDto() { FeedName = "TestFeed", FeedUrl = "http://test.feed.de", IsActive = true, Id = 1};
            RdfParser parser = new RdfParser();
            var result = parser.Parse(abo ,testText);
            Assert.AreEqual(60, result.Count());
        }
    }
}
