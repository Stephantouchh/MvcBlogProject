using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        Repository<Category> repocategory = new Repository<Category>();
        public List<Category> GetAll()
        {
            return repocategory.List();
        }
        public Category GetByID(int id)
        {
            return repocategory.Get(x => x.CategoryID == id);
        }
        public int CategoryAddBL(Category category)
        {
            if (category.CategoryName == "" || category.CategoryDescription == "" || category.CategoryName.Length <= 4 || category.CategoryName.Length >= 30)
            {
                return -1;
            }
            return repocategory.Insert(category);
        }
        //Kategoriyi id değerine göre edit sayfasına taşıma
        public Category FindCategory(int id)
        {
            return repocategory.Find(x => x.CategoryID == id);
        }
        //Kategori Bilgilerini Güncelleme Sayfası
        public int EditCategory(Category p)
        {
            Category category = repocategory.Find(x => x.CategoryID == p.CategoryID);
            if (p.CategoryName == "" | p.CategoryName.Length <= 4 | p.CategoryName.Length >= 30)
            {
                return -1;
            }
            category.CategoryName = p.CategoryName;
            category.CategoryDescription = p.CategoryDescription;
            return repocategory.Update(category);
        }
        public int DeleteCategoryBL(int id)
        {
            Category category = repocategory.Find(x => x.CategoryID == id);
            return repocategory.Update(category);
        }
    }
}
