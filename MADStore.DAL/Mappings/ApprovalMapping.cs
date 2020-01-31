using MADStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.DAL.Mappings
{
    public class ApprovalMapping : EntityTypeConfiguration<Approval>
    {
        public ApprovalMapping()
        {
            HasKey(a => new { a.UserID, a.CombinationID });
        }
    }
}
