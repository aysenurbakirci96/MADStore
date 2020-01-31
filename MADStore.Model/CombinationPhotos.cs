using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class CombinationPhotos
    {
        public int CombinationID { get; set; }
        public int ProductID { get; set; }

        //Navigation Property
        //Bir kombin fotoğrafları bir kombine ait olur.
        //Bir kombin fotoğrafları bir ürüne ait olur.

        public virtual Combination Combination { get; set; }
        public virtual Product Product { get; set; }
    }
}
