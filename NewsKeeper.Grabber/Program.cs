using System.Net;
using System.Text;
using NewsKeeper.Grabber.Parser;
using NewsKeeper.LogicLayer;

namespace NewsKeeper.Grabber
{
    class Program
    {
        static void Main(string[] args)
        {
                var newsFeedService = new NewsFeedService();
                var feeds = newsFeedService.GetNewsFeeds();
                foreach (var feed in feeds)
                {
                    var rss = FeedLoader(feed.FeedUrl);
                    var parser = new RdfParser();
                    var newsfeedItem = parser.Parse(feed, rss);
                    newsFeedService.StoreFeedItems(newsfeedItem);
                    newsFeedService.UpdateAbo(feed);
                }
        }

        private static string FeedLoader(string url)
        {
            var client = new WebClient();
            client.Encoding = Encoding.UTF8;
            var rss = client.DownloadString(url);
            return rss;
        }

    }
}
