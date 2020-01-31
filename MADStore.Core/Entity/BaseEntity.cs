using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Core.Entity
{
    public abstract class BaseEntity
    {
        //Tüm classlarda olmasını istediğimiz kolonu yazarız.

        public BaseEntity()
        {
            IsDeleted = false;
            CreatedDate = DateTime.Now;
        }

        public int ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
