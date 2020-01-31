using MADStore.BLL.BaseService;
using MADStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.BLL.Abstract
{
    public interface IUserService : IBaseService <User>
    {
        User IsRegisteredUser(string email);

        User GetLogin(string email, string password);

        ICollection<User> GetNotApprovedUser();
    }
}
