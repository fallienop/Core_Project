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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDAL _smDAL;

       
        public SocialMediaManager(ISocialMediaDAL smDAL)
        {
            _smDAL = smDAL;
        }

        public SocialMedia GetById(int id)
        {
            return _smDAL.GetByID(id);
        }

        public List<SocialMedia> GetList()
        {
            return _smDAL.GetList();
        }

        public void TAdd(SocialMedia t)
        {
            _smDAL.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _smDAL.Delete(t);
        }

        public void TUpdate(SocialMedia t)
        {
            _smDAL.Update(t);
        }
    }
}
