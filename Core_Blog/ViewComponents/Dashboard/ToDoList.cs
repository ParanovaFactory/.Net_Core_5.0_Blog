using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.ViewComponents.Dashboard
{
    public class ToDoList : ViewComponent
    {
        ToDoListManager manager = new ToDoListManager(new EFToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.GetList();
            return View(values);
        }
    }
}
