using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class ProductDetail
    {
        public int ProductID { get; set; }
        public int ColorID { get; set; }
        public int SizeID { get; set; }

        //Navigation Property
        //Bir ürün detayı bir ürüne ait olabilir.
        //Bir ürün detayında bir renk olur.
        //Bir ürün detayında bir beden olur.

        public virtual Product Product { get; set; }
        public virtual Color Color { get; set; }
        public virtual Size Size { get; set; }
    }
}
