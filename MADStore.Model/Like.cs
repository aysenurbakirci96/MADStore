using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
   public class Like : BaseEntity
    {
        public int UserID { get; set; }
        public int CombinationID { get; set; }

        //Navigation Property
        //Bir beğeni bir kullanıcıya ait olur.
        //Bir beğeni bir kombine ait olabilir.

        public virtual User User { get; set; }
        public virtual Combination Combination { get; set; }
    }
}
