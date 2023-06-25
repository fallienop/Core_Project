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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDAL _portfolioDAL;

        public PortfolioManager(IPortfolioDAL portfolioDAL)
        {
            _portfolioDAL = portfolioDAL;
        }

        public Portfolio GetById(int id)
        {
            return _portfolioDAL.GetByID(id);
        }

        public List<Portfolio> GetList()
        {
            return _portfolioDAL.GetList();
        }

        public void TAdd(Portfolio t)
        {
            _portfolioDAL.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfolioDAL.Delete(t);
        }

        public void TUpdate(Portfolio t)
        {
            _portfolioDAL.Update(t);
        }
    }
}
