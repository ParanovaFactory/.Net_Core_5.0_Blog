using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class PartialController : Controller
    {
        public PartialViewResult Sidebar()
        {
            return PartialView();
        }

        public PartialViewResult Navbar()
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }

        public PartialViewResult Header()
        {
            return PartialView();
        }

        public PartialViewResult Head()
        {
            return PartialView();
        }

        public PartialViewResult Script()
        {
            return PartialView();
        }
    }
}
