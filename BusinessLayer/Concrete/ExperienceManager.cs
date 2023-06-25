using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDAL _experienceDAL;

        public ExperienceManager(IExperienceDAL experienceDAL)
        {
            _experienceDAL = experienceDAL;
        }

        public Experience GetById(int id)
        {
            return _experienceDAL.GetByID(id);
        }

        public List<Experience> GetList()
        {
            return _experienceDAL.GetList();
        }

        public void TAdd(Experience t)
        {
            _experienceDAL.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experienceDAL.Delete(t);
        }

        public void TUpdate(Experience t)
        { 
            _experienceDAL.Update(t);
        }
    }
}
