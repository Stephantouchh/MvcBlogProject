using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> CommentByBlog(int id);
        List<Comment> CommentByStatusTrue();
        List<Comment> CommentByStatusFalse();
        List<Comment> CommentList();
        void CommentStatusChangeToFalse(int id);
        void CommentStatusChangeToTrue(int id);
    }
}
