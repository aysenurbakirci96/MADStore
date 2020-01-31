using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class Product : BaseEntity
    {
        public Product()
        {
            ProductDetails = new HashSet<ProductDetail>();
            Comments = new HashSet<Comment>();
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public decimal Price { get; set; }
        public string PhotoUrl { get; set; }
        public int Stock { get; set; }
        public int CategoryID { get; set; }

        //Navigation Property
        //Bir ürünün birden fazla ürün detayı olabilir.
        //Bir ürünün birden fazla yorumu olabilir.
        //Bir ürünün bir kategorisi olabilir.

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Category Category { get; set; }
    }
}
