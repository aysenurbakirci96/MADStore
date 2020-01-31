using MADStore.Core.DAL.Entity_Framework;
using MADStore.DAL.Abstract;
using MADStore.DAL.MADStoreContext;
using MADStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.DAL.Concrete
{
   public class ModelistProcessRepository : EFRepositoryBase <ModelistProcess, MADStoreDbContext>, IModelistProcessDAL
    {
    }
}
