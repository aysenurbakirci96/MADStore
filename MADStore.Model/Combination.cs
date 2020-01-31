using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class Combination : BaseEntity
    {
        public Combination()
        {
            Comments = new HashSet<Comment>();
            Likes = new HashSet<Like>();
            Approvals = new HashSet<Approval>();
            CombinationPhotos = new HashSet<CombinationPhotos>();
        }

        public int LikeID { get; set; }
        public int CommentID { get; set; }
        public int UserID { get; set; }

        //Navigation Property
        //Bir kombinin birden fazla yorumu olabilir.
        //Bir kombinin birden fazla beğenisi olabilir.
        //Bir kombinin birden fazla onayı olabilir.
        //Bir kombinin birden fazla kombin fotoğrafı olabilir.

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Approval> Approvals { get; set; }
        public virtual ICollection<CombinationPhotos> CombinationPhotos { get; set; }
    }
}
