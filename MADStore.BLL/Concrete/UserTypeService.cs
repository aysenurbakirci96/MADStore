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
    public class UserTypeService : IUserTypeService
    {
        IUserTypeDAL _userTypeDAL;
        public UserTypeService(IUserTypeDAL userTypeService)
        {
            _userTypeDAL = userTypeService;
        }
        public void Delete(UserTypes entity)
        {
            _userTypeDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            UserTypes usertype = _userTypeDAL.Get(a => a.ID == entityID);
            _userTypeDAL.Delete(usertype);

        }

        public UserTypes Get(int entityID)
        {
            return _userTypeDAL.Get(a => a.ID == entityID);
        }

        public ICollection<UserTypes> GetAll()
        {
            return _userTypeDAL.GetAll();
        }

        public void Insert(UserTypes entity)
        {
            _userTypeDAL.Add(entity);
        }

        public void Update(UserTypes entity)
        {
            _userTypeDAL.Update(entity);
        }
    }
}
