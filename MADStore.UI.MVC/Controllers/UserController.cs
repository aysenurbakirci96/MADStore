using MADStore.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MADStore.UI.MVC.Controllers
{
    public class UserController : Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;

        public UserController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: User
        public ActionResult Products()
        {
            var products = _productService.GetAll();
            return View();
        }

        public ActionResult _CategoryOfProducts(int? id)
        {
            if (id != null)
            {
                var productlist = _productService.GetProductOfCategory(id.Value);
                return PartialView(productlist); 
            }
            return PartialView(_productService.GetAll());
        }

        public ActionResult _CategoryMenu()
        {
            return PartialView(_categoryService.GetAll());
        }
    }
}