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
   public class ProductService : IProductService
    {
        IProductDAL _productDAL;

        public ProductService(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void Insert(Product entity)
        {
            _productDAL.Add(entity);
        }

        public void Update(Product entity)
        {
            _productDAL.Update(entity);
        }

        public void Delete(Product entity)
        {
            _productDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            Product prd = _productDAL.Get(a => a.ID == entityID);
            _productDAL.Delete(prd);
        }

        public Product Get(int entityID)
        {
            return _productDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Product> GetAll()
        {
            return _productDAL.GetAll();
        }

        public List<Product> GetProductOfCategory(int categoryID)
        {
           return _productDAL.GetAll(a => a.ID == categoryID).ToList();
        }
    }
}
