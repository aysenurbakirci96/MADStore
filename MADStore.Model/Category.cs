using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        //Navigation Property
        //Bir kategoride birden fazla ürün olabilir.

        public virtual ICollection<Product> Products { get; set; }
    }
}
