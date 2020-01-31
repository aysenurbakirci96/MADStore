using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class Approval 
    {
        public int UserID { get; set; }
        public int CombinationID { get; set; }

        //Navigation Property
        //Bir onay bir kullanıcıya ait olabilir.
        //Bir onay bir kombine ait olabilir.

        public virtual User User { get; set; }
        public virtual Combination Combination { get; set; }
    }
}
