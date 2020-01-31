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
    public class ModelistProcessService : IModelistProcessService
    {
        IModelistProcessDAL _modelistProcessDAL;

        public ModelistProcessService(IModelistProcessDAL modelistProcessDAL)
        {
            _modelistProcessDAL = modelistProcessDAL;
        }

        public void Insert(ModelistProcess entity)
        {
            _modelistProcessDAL.Add(entity);
        }

        public void Update(ModelistProcess entity)
        {
            _modelistProcessDAL.Update(entity);
        }

        public void Delete(ModelistProcess entity)
        {
            _modelistProcessDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            ModelistProcess mp = _modelistProcessDAL.Get(a => a.ID == entityID);
            _modelistProcessDAL.Delete(mp);
        }

        public ModelistProcess Get(int entityID)
        {
            return _modelistProcessDAL.Get(a => a.ID == entityID);
        }

        public ICollection<ModelistProcess> GetAll()
        {
            return _modelistProcessDAL.GetAll();
        }
    }
}
