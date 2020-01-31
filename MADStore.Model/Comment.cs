using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class Comment : BaseEntity //Yorum
    {
        public string Content { get; set; }
        public DateTime ContentDate { get; set; }
        public int UserID { get; set; }
        public int CombinationID { get; set; }
        public int ProductID { get; set; }

        //Navigation Property
        //Bir yorum bir kullanıcıya ait olur.
        //Bir yorum bir kombine ait olabilir.
        //Bir yorum bir ürüne ait olabilir.

        public virtual User User { get; set; }
        public virtual Combination Combination { get; set; }
        public virtual Product Product { get; set; }
    }
}
