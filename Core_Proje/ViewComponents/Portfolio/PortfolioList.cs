using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager portfoliomanager = new PortfolioManager(new efPortfolioDAL());
        
        public IViewComponentResult Invoke()
        {
            var value=portfoliomanager.GetList();
            return View(value); 

        }
    }
}
