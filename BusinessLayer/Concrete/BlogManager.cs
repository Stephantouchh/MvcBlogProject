using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        Repository<Blog> repoblog = new Repository<Blog>();

        public List<Blog> GetAll()
        {
            return repoblog.List();
        }
        public List<Blog> GetBlogByID(int id)
        {
            return repoblog.List(x => x.BlogID == id);
        }
    }
}
