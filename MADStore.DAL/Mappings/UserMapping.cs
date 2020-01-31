using MADStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.DAL.Mappings
{
    public class UserMapping: EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasRequired(x => x.UserTypes).WithMany(X => X.Users).HasForeignKey(x => x.UserTypesID);
        }
    }
}
