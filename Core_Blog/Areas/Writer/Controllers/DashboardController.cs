using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace Core_Blog.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            //string api = "122353ded9b2864578e4f73d30ebd4d7";
            //string connection = "\r\nhttps://api.openweathermap.org/data/2.5/weather?q=gaziantep&appid=" + api;
            //XDocument document = XDocument.Load(connection);
            //ViewBag.v5 = document.Descendants("tempature").ElementAt(0).Attribute("value").Value;

            ViewBag.v1 = c.UserMessages.Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count();
            ViewBag.v4 = c.Skills.Count();
            return View();
        }
    }
}
