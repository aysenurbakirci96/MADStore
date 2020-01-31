using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class Color : BaseEntity
    {
        public Color()
        {
            ProductDetails = new HashSet<ProductDetail>();
        }

        public string Name { get; set; }

        //Navigation Property
        //Bir renk birden fazla ürün detayına ait olabilir.

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
