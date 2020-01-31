using MADStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.DAL.Mappings
{
    public class CombinationPhotosMapping : EntityTypeConfiguration<CombinationPhotos>
    {
        public CombinationPhotosMapping()
        {
            HasKey(a => new { a.CombinationID, a.ProductID });
        }
    }
}
