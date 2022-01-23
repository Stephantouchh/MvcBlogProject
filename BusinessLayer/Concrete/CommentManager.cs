using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repocomment = new Repository<Comment>();
        public List<Comment> CommentList()
        {
            return repocomment.List();
        }
        public List<Comment> CommentByBlog(int id)
        {
            return repocomment.List(x => x.BlogID == id);
        }
        public int CommentAdd(Comment c)
        {
            if (c.CommentText.Length <= 4 || c.CommentText.Length >= 301 || c.UserName == "" || c.Mail == "" || c.UserName.Length <= 4)
            {
                return -1;
            }
            return repocomment.Insert(c);
        }
    }
}
