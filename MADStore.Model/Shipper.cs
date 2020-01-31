using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class Shipper : BaseEntity
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public string ShipperName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        //Navigation Property
        //Bir kargo birden fazla siparişe ait olabilir.

        public virtual ICollection<Order> Orders { get; set; }
    }
}
