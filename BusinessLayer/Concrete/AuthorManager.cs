using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public List<Author> GetList()
        {
            return _authorDal.List();
        }

        public Author GetByID(int id)
        {
            return _authorDal.GetByID(id);
        }

        public void TAdd(Author t)
        {
            t.Status = true;
            _authorDal.Insert(t);
        }

        public void TDelete(Author t)
        {
            _authorDal.Update(t);
        }

        public void TUpdate(Author t)
        {
            _authorDal.Update(t);
        }
    }
}
