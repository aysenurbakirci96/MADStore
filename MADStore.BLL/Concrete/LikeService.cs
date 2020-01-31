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
    public class LikeService : ILikeService
    {
        ILikeDAL _likeDAL;

        public LikeService(ILikeDAL likeDAL)
        {
            _likeDAL = likeDAL;
        }

        public void Insert(Like entity)
        {
            _likeDAL.Add(entity);
        }

        public void Update(Like entity)
        {
            _likeDAL.Update(entity);
        }

        public void Delete(Like entity)
        {
            _likeDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            Like lk = _likeDAL.Get(a => a.ID == entityID);
            _likeDAL.Delete(lk);
        }

        public Like Get(int entityID)
        {
            return _likeDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Like> GetAll()
        {
            return _likeDAL.GetAll();
        }
    }
}
