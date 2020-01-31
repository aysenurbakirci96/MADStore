[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MADStore.UI.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(MADStore.UI.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace MADStore.UI.MVC.App_Start
{
    using System;
    using System.Web;
    using MADStore.BLL.Abstract;
    using MADStore.BLL.Concrete;
    using MADStore.BLL.IOC.Ninject;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ICategoryService>().To<CategoryService>();
            kernel.Bind<IColorService>().To<ColorService>();
            kernel.Bind<ICombinationService>().To<CombinationService>();
            kernel.Bind<ICommentService>().To<CommentService>();
            kernel.Bind<ILikeService>().To<LikeService>();
            kernel.Bind<IModelistProcessService>().To<ModelistProcessService>();
            kernel.Bind<IOrderService>().To<OrderService>();
            kernel.Bind<IProductService>().To<ProductService>();
            kernel.Bind<IShipperService>().To<ShipperService>();
            kernel.Bind<ISizeService>().To<SizeService>();
            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<IUserTypeService>().To<UserTypeService>();

            kernel.Load<CustomDALModule>();
        }        
    }
}
