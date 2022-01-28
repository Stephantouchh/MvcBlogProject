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
        public Blog GetByID(int id)
        {
            return repoblog.Get(x => x.BlogID == id);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoblog.List(x => x.AuthorID == id);
        }
        public List<Blog> GetBlogByCategory(int id)
        {
            return repoblog.List(x => x.CategoryID == id);
        }
        public int BlogAddBL(Blog blog)
        {
            if (blog.BlogTitle == "" || blog.BlogImage == "" || blog.BlogTitle.Length <= 5 || blog.BlogContent.Length <= 200)
            {
                return -1;
            }
            return repoblog.Insert(blog);
        }
        public int DeleteBlogBL(int p)
        {
            Blog blog = repoblog.Find(x => x.BlogID == p);
            return repoblog.Delete(blog);
        }
        public Blog FindBlog(int id)
        {
            return repoblog.Find(x => x.BlogID == id);
        }
        public int UpdateBlog(Blog p)
        {
            Blog blog = repoblog.Find(x => x.BlogID == p.BlogID);
            blog.BlogTitle = p.BlogTitle;
            blog.BlogContent = p.BlogContent;
            blog.BlogDate = p.BlogDate;
            blog.BlogImage = p.BlogImage;
            blog.BlogImageCover = p.BlogImageCover;
            blog.CategoryID = p.CategoryID;
            blog.AuthorID = p.AuthorID;
            return repoblog.Update(blog);
        }
        public void DeleteBlog(Blog blog)
        {
            repoblog.Update(blog);
        }
    }
}
