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
    public class FeatureManager : IFeatureService
    {
        IFeatureDAL _featureDAL;

        public FeatureManager(IFeatureDAL featureDAL)
        {
            _featureDAL = featureDAL;
        }

        public Feature GetById(int id)
        {
            return _featureDAL.GetByID(id);
        }

        public List<Feature> GetList()
        {
            return _featureDAL.GetList();
        }

        public void TAdd(Feature t)
        {
            _featureDAL.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDAL.Delete(t);
        }

        public void TUpdate(Feature t)
        {
            _featureDAL.Update(t);
        }
    }
}
