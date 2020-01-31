using MADStore.DAL.Abstract;
using MADStore.DAL.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.BLL.IOC.Ninject
{
    public class CustomDALModule : NinjectModule
    {
        public override void Load()
        {
            //Daldaki classları interfaceleri ile bağladık.

            Bind<ICategoryDAL>().To<CategoryRepository>();
            Bind<IColorDAL>().To<ColorRepository>();
            Bind<ICombinationDAL>().To<CombinationRepository>();
            Bind<ICommentDAL>().To<CommentRepository>();
            Bind<ILikeDAL>().To<LikeRepsitory>();
            Bind<IModelistProcessDAL>().To<ModelistProcessRepository>();
            Bind<IOrderDAL>().To<OrderRepository>();
            Bind<IProductDAL>().To<ProductRepository>();
            Bind<IShipperDAL>().To<ShipperRepository>();
            Bind<ISizeDAL>().To<SizeRepository>();
            Bind<IUserDAL>().To<UserRepository>();
            Bind<IUserTypeDAL>().To<UserTypeRepository>();
        }
    }
}
