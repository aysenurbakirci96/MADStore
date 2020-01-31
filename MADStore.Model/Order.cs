using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class Order : BaseEntity
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int UserID { get; set; }
        public int ShipperID { get; set; }

        //Navigation Property
        //Bir sipariş bir kullanıcıya ait olabilir.
        //Bir sipariş birden fazla sipariş detayı alabilir.
        //Bir siparişin bir kargosu olur.

        public virtual User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Shipper Shipper { get; set; }

    }
}
