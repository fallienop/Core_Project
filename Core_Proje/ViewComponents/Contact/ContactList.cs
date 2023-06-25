using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class ContactList:ViewComponent
    {
        ContactManager contactmanager = new ContactManager(new efContactDAL());

        public IViewComponentResult Invoke()
        {
            var res = contactmanager.GetList();
            return View(res);
        }
    }
}
