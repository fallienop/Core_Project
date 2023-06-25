using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Testimonial

{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager testimonialmanager = new TestimonialManager(new efTestimonialDAL());

        public IViewComponentResult Invoke()
        {
            var value=testimonialmanager.GetList();
            return View(value);
        }
    }
}
