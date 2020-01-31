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
    public class CombinationService : ICombinationService
    {
        ICombinationDAL _combinationDAL;

        public CombinationService(ICombinationDAL combinationDAL)
        {
            _combinationDAL = combinationDAL;
        }

        public void Insert(Combination entity)
        {
            _combinationDAL.Add(entity);
        }

        public void Update(Combination entity)
        {
            _combinationDAL.Update(entity);
        }

        public void Delete(Combination entity)
        {
            _combinationDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            Combination cmb = _combinationDAL.Get(a => a.ID == entityID);
            _combinationDAL.Delete(cmb);
        }

        public Combination Get(int entityID)
        {
            return _combinationDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Combination> GetAll()
        {
            return _combinationDAL.GetAll();
        }
    }
}
