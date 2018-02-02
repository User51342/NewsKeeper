using System.Web.Mvc;
using NewsKeeper.LogicLayer;

namespace NewsKeeper.WebClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";
            NewsFeedService newsFeedService = new NewsFeedService();
            var newsFeedAboDto = newsFeedService.GetNewsFeeds();
            return View(newsFeedAboDto);
        }

        public ActionResult NewsFeed(int id)
        {
            NewsFeedService newsFeedService = new NewsFeedService();
            var items = newsFeedService.GetNewsFeedItems(id);
            return View(items);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}