using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubscribeMailService
    {
        List<SubscribeMail> GetList();
        void SubscribeMailAdd(SubscribeMail subscribeMail);
        SubscribeMail GetByID(int id);
        void SubscribeMailDelete(SubscribeMail subscribeMail);
        void SubscribeMailUpdate(SubscribeMail subscribeMail);
    }
}
