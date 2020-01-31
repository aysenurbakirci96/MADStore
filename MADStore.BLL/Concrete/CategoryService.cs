using MADStore.BLL.Abstract;
using MADStore.DAL.Abstract;
using MADStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.BLL.Concrete
{
    public class CategoryService : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryService(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void Insert(Category entity)
        {
            _categoryDAL.Add(entity);
        }

        public void Update(Category entity)
        {
            _categoryDAL.Update(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            Category cat = _categoryDAL.Get(a => a.ID == entityID);
            Delete(cat);
        }

        public Category Get(int entityID)
        {
            return _categoryDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }
    }
}
