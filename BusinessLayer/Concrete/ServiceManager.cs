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
    public class ServiceManager : IServiceService
    {
        IServiceDAL _serviceDAL;

        public ServiceManager(IServiceDAL serviceDAL)
        {
            _serviceDAL = serviceDAL;
        }

        public Service GetById(int id)
        {
            return _serviceDAL.GetByID(id);
        }

        public List<Service> GetList()
        {
           return _serviceDAL.GetList();
        }

        public void TAdd(Service t)
        {
            _serviceDAL.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDAL.Delete(t);
        }

        public void TUpdate(Service t)
        {
            _serviceDAL.Update(t);
        }
    }
}
