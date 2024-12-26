using BusinessLayer.Abstract;
using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Blog.ViewComponents.Dashboard
{
    public class Messages : ViewComponent
    {
        UserMessageManager userMessageManager = new UserMessageManager(new EFUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = userMessageManager.GetUserMessageWithUserService().OrderByDescending(x=>x.MessageId).Take(4).ToList();
            return View(values);
        }
    }
}
