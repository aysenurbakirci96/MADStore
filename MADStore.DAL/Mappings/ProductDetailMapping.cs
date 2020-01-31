using MADStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.DAL.Mappings
{
    public class ProductDetailMapping : EntityTypeConfiguration<ProductDetail>
    {
        public ProductDetailMapping()
        {
            HasKey(a => new { a.ColorID, a.ProductID, a.SizeID });
        }
    }
}
