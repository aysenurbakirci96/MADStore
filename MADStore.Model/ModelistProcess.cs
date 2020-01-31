using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Model
{
    public class ModelistProcess : BaseEntity
    {
        public string NoteTitle { get; set; }
        public string NoteContent { get; set; }
        public int UserID { get; set; }

        //Navigation Property
        //Bir modelist işlemi bir kullanıcıya ait olur.

        public virtual User User { get; set; }
    }
}
