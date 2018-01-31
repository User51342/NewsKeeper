using System.Web.Mvc;
using NewsKeeper.LogicLayer;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            NewsFeedService newsFeedService = new NewsFeedService();
            var newsFeedAboDto = newsFeedService.GetNewsFeeds();
            return View(newsFeedAboDto);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}