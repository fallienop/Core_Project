using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager servicemanager = new ServiceManager(new efServiceDAL());
        public IViewComponentResult Invoke()
        {
            var result = servicemanager.GetList();
            return View(result);
        }
    }
}
