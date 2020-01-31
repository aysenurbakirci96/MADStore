using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class OrderDetail
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool Canceled { get; set; } //Sipariş iptali 
        public int OrderID { get; set; }
        public int ProductID { get; set; }

        //Navigation Property
        //Bir sipariş detayı bir ürüne ait olabilir.
        //Bir sipariş detayı bir siparişe ait olabilir.

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
