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
    public class MessageManager : IMessageService
    {
        IMessageDAL _messageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public Message GetById(int id)
        {
            return _messageDAL.GetByID(id);
        }

        public List<Message> GetList()
        {
           return _messageDAL.GetList();
        }

        public void TAdd(Message t)
        {
            _messageDAL.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDAL.Delete(t);
        }

        public void TUpdate(Message t)
        {
            _messageDAL.Update(t);
        }
    }
}
