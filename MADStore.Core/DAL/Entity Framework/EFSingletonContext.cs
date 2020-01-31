using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.Core.DAL.Entity_Framework
{
    public class EFSingletonContext<TContext>
        where TContext : DbContext, new()
    {
        private static TContext _madStoreDb;

        public static TContext MadStoreDb
        {
            get
            {
                if (_madStoreDb == null)
                {
                    _madStoreDb = new TContext();
                }
                return _madStoreDb;
            }
        }
    }
}
