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
    public class SkillManager : ISkillService
    {
        ISkillDAL _skillDAL;

        public SkillManager(ISkillDAL skillDAL)
        {
            _skillDAL = skillDAL;
        }

        public Skill GetById(int id)
        {
            return _skillDAL.GetByID(id);
        }

        public List<Skill> GetList()
        {
            return _skillDAL.GetList();
        }

        public void TAdd(Skill t)
        {
            _skillDAL.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDAL.Delete(t);
        }

        public void TUpdate(Skill t)
        {
            _skillDAL.Update(t);
        }
    }
}
