using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class UserTypes : BaseEntity
    {
        public UserTypes()
        {
            Users = new HashSet<User>();
        }

        public string UserTypeName { get; set; }

        //Navigation Property
        //Bir kullanıcı türü birden fazla kullanıcıya ait olabilir.

        public virtual ICollection<User> Users { get; set; }
    }
}
