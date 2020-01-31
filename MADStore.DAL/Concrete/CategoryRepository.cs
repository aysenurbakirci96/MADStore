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
    public class CategoryRepository : EFRepositoryBase <Category, MADStoreDbContext>, ICategoryDAL
    {
        //EFRepositoryBase sayesinde tüm methodların içeriğine erişebildik.
        //Method gövdelerine de ICategoryDAL'ın kalıtımı olan IRepository sayesinde erişebildik.
    }
}
