using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class User : BaseEntity
    {
        public User()
        {
            IsApproved = false;
            Comments = new HashSet<Comment>();
            Likes = new HashSet<Like>();
            Approvals = new HashSet<Approval>();
            ModelistProcesses = new HashSet<ModelistProcess>();
            Orders = new HashSet<Order>();
            Combinations = new HashSet<Combination>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsApproved { get; set; } //Kullanıcı onaylandı mı ?
        public int UserTypesID { get; set; }

        //Navigation Property
        //Bir kullanıcının bir kullanıcı türü olur.
        //Bir kullanıcının birden fazla yorumu olabilir.
        //Bir kullanıcının birden fazla beğenisi olabilir.
        //Bir kullanıcının birden fazla onayı olabilir.
        //Bir kullanıcının birden fazla modelist işlemi olabilir.
        //Bir kullanıcının birden fazla siparişi olabilir.
        //Bir kullanıcının birden fazla kombini olabilir.

        public virtual UserTypes UserTypes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Approval> Approvals { get; set; }
        public virtual ICollection<ModelistProcess> ModelistProcesses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Combination> Combinations { get; set; }
    }
}
