using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repouser = new Repository<Author>();

        public List<Author> GetAuthorByMail(string p)
        {
            return repouser.List(x => x.Mail == p);
        }
    }
}
