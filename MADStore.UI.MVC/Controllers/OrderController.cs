using MADStore.BLL.Abstract;
using MADStore.Model;
using MADStore.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MADStore.UI.MVC.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        
        // GET: Order
        public ActionResult ConfirmCart()
        {
            if (Session["cart"] != null)
            {
                MyCart cart = Session["cart"] as MyCart;
                if (cart.GetAllCartItem.Count > 0)
                {
                    MADStore.Model.User kullanici = Session["kullanici"] as User;
                    Order order = new Order();
                    order.OrderDate = DateTime.Now;
                    order.ShippedDate = DateTime.Now;
                    order.ShipperID = 1;
                    order.UserID = kullanici.ID;
                    order.OrderDetails = new List<OrderDetail>();
                    foreach (CartItemViewModel item in cart.GetAllCartItem)
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.ProductID = item.ID;
                        orderDetail.Quantity = item.Amount;
                        orderDetail.Canceled = false;
                        order.OrderDetails.Add(orderDetail);

                    }

                    _orderService.Insert(order);
                    Session["cart"] = new MyCart();
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Index", "Cart");
        }
    }
}