using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class Size : BaseEntity
    {
        public Size()
        {
            ProductDetails = new HashSet<ProductDetail>();
        }

        public string Name { get; set; }

        //Navigation Property
        //Bir beden birden fazla ürün detayı olabilir.

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
