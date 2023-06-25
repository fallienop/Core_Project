using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.EntityFramework;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDAL _contactDal;

        public ContactManager(IContactDAL contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetById(int id)
        {
          return _contactDal.GetByID(id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetList();
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
