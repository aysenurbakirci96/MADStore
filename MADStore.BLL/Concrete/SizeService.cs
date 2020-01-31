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
    public class SizeService : ISizeService
    {
        ISizeDAL _sizeDAL;

        public SizeService(ISizeDAL sizeDAL)
        {
            _sizeDAL = sizeDAL;
        }

        public void Insert(Size entity)
        {
            _sizeDAL.Add(entity);
        }

        public void Update(Size entity)
        {
            _sizeDAL.Update(entity);
        }

        public void Delete(Size entity)
        {
            _sizeDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            Size size = _sizeDAL.Get(a => a.ID == entityID);
            _sizeDAL.Delete(size);
        }

        public Size Get(int entityID)
        {
            return _sizeDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Size> GetAll()
        {
            return _sizeDAL.GetAll();
        }
    }
}
