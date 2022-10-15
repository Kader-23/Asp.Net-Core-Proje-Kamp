using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCtategoryRepository;
        public CategoryManager()
        {
            efCtategoryRepository = new EfCategoryRepository();
        }

         public void CategoryAdd(Category category)
        {
            efCtategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {

            efCtategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCtategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return efCtategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCtategoryRepository.GetListAll();
        }
    }
}
