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
    public class UserService : IUserService
    {
        IUserDAL _userDAL;

        public UserService(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public void Insert(User entity)
        {
            _userDAL.Add(entity);
        }

        public void Update(User entity)
        {
            _userDAL.Update(entity);
        }

        public void Delete(User entity)
        {
            _userDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            User user = _userDAL.Get(a => a.ID == entityID);
            _userDAL.Delete(user);
        }

        public User Get(int entityID)
        {
            return _userDAL.Get(a => a.ID == entityID);
        }

        public ICollection<User> GetAll()
        {
            return _userDAL.GetAll();
        }

        public User IsRegisteredUser(string email)
        {
            return _userDAL.Get(a => a.Email == email); //Eğer null değilse diyerek kontrolünü yapabiliriz.
        }

        public User GetLogin(string email, string password)
        {
            ICollection<User> users = _userDAL.GetAll();

            User user = users.Where(a => a.IsApproved && (a.Email == email && a.Password == password)).SingleOrDefault();

            return user;
        }

        public ICollection<User> GetNotApprovedUser()
        {
            ICollection<User> users = _userDAL.GetAll();

            ICollection<User> user = users.Where(a => a.IsApproved == false).ToList();

            return user;
        }
    }
}
