using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {

        MessageManager messagemanager = new MessageManager(new efMessageDAL());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Message p) 
        //{
        //    p.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString);
        //    p.Status = false;
        //    messagemanager.TAdd(p);
        //    return View();
        //}
    }
}
