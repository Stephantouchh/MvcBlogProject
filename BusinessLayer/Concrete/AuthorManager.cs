using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class AuthorManager
    {
        Repository<Author> repoauthor = new Repository<Author>();

        //Tüm Yazar Listesini Getirme
        public List<Author> GetAll()
        {
            return repoauthor.List();
        }

        //Yeni Yazar Ekleme İşlemi
        public int AddAuthorBL(Author p)
        {
            //Parametreden Gönderilen değerlerin geçerliliğinin kontrolü
            if (p.AuthorName == "" | p.AuthorShort == "" | p.AuthorTitle == "")
            {
                return -1;
            }
            p.Status = true;
            return repoauthor.Insert(p);
        }
        //Yazarı id değerine göre edit sayfasına taşıma
        public Author FindAuthor(int id)
        {
            return repoauthor.Find(x => x.AuthorID == id);
        }
        //Yazar Bilgilerini Güncelleme Sayfası
        public int EditAuthor(Author p)
        {
            Author author = repoauthor.Find(x => x.AuthorID == p.AuthorID);
            author.AuthorName = p.AuthorName;
            author.AuthorImage = p.AuthorImage;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorTitle = p.AuthorTitle;
            author.AuthorShort = p.AuthorShort;
            author.Mail = p.Mail;
            author.Password = p.Password;
            author.PhoneNumber = p.PhoneNumber;
            return repoauthor.Update(author);
        }
    }
}
