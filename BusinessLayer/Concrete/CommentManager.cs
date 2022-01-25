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
        public List<Comment> CommentByStatusTrue()
        {
            return repocomment.List(x => x.CommentStatus == true);
        }
        public List <Comment> CommentByStatusFalse()
        {
            return repocomment.List(x => x.CommentStatus == false);
        }
        public int CommentAdd(Comment c)
        {
            if (c.CommentText.Length <= 4 || c.CommentText.Length >= 301 || c.UserName == "" || c.Mail == "" || c.UserName.Length <= 4)
            {
                return -1;
            }
            return repocomment.Insert(c);
        }
        public int CommentStatusChangeToFalse(int id)
        {
            Comment comment = repocomment.Find(x => x.CommentID == id);
            comment.CommentStatus = false;
            return repocomment.Update(comment);
        }
        public int CommentStatusChangeToTrue(int id)
        {
            Comment comment = repocomment.Find(x => x.CommentID == id);
            comment.CommentStatus = true;
            return repocomment.Update(comment);
        }
    }
}
