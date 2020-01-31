using MADStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.BLL.BaseService
{
    public interface IBaseService<T>
        where T : BaseEntity //BaseEntity'i kalıtım alan tüm classlarlar bu methodlara erişebilsin dedik.
    {
        void Insert(T entity);
        void Delete(T entity);
        void DeleteById(int entityID);
        void Update(T entity);
        T Get(int entityID);
        ICollection<T> GetAll();
    }
}
