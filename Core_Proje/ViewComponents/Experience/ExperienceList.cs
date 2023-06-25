using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManager experiencemanager = new ExperienceManager(new efExperienceDAL());
        
        public IViewComponentResult Invoke()
        {
            var value=experiencemanager.GetList();
            return View(value);

        }
    }
}
