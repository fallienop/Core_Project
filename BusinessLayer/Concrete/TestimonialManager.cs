using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDAL _testimonialDAL;

        public TestimonialManager(ITestimonialDAL testimonialDAL)
        {
            _testimonialDAL = testimonialDAL;
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDAL.GetByID(id);
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDAL.GetList();
        }

        public void TAdd(Testimonial t)
        {
            _testimonialDAL.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDAL.Delete(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDAL.Update(t);
        }
    }
}
