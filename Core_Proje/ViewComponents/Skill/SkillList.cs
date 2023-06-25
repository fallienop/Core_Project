using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Core_Proje.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager skillmanager = new SkillManager(new efSkillDAL());

        public IViewComponentResult Invoke()
        {
            var values=skillmanager.GetList();

            return View(values);

        }
    }
}
