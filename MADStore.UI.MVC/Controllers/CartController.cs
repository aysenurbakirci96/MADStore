using MADStore.BLL.Abstract;
using MADStore.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MADStore.UI.MVC.Controllers
{
    public class CartController : Controller
    {
        IProductService _productService;

        public CartController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _CartButton()
        {
            return PartialView();
        }

        public ActionResult AddToCart(int id)
        {
            //MyCartı session içindeki karta eşitliyoruz.
            MyCart cart = Session["cart"] as MyCart;
            CartItemViewModel cartItem = new CartItemViewModel();
            var eklenenUrun = _productService.Get(id); //Eklenen albümü bul. Sepete ekleye basınca o ID ye ait ürünü bulması için
            //CartItem ın özelliklerine eşitle
            cartItem.ID = eklenenUrun.ID;
            cartItem.Name = eklenenUrun.Title;
            cartItem.Price = eklenenUrun.Price;
            cartItem.Amount = 1;
            //Session dan oluşturduğum carta ekliyorum
            cart.AddCart(cartItem);
            Session["cart"] = cart;
            return PartialView("_CartButton"); //Sepet içindeki ürün sayısını dönmesi için
        }
        public ActionResult _CartList()
        {

            return PartialView();
        }

        public ActionResult UpdateCart(short amount, int id)
        {
            MyCart guncellenenSepet = Session["cart"] as MyCart;
            guncellenenSepet.Update(id, amount);
            Session["cart"] = guncellenenSepet;
            return RedirectToAction("_CartList", "Cart");
        }

        public ActionResult DeleteItemCart(int id)
        {
            MyCart silinecekCart = Session["cart"] as MyCart;
            silinecekCart.Delete(id);
            Session["cart"] = silinecekCart;

            return RedirectToAction("_CartList", "Cart");
        }
    }
}