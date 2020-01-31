using MADStore.BLL.Concrete;
using MADStore.Model;
using MADStore.UI.MVC.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MADStore.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        UserService _userService;

        public AccountController(UserService userService)
        {
            _userService = userService;
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            try
            {
                if (_userService.IsRegisteredUser(user.Email) == null)
                {
                    user.UserTypesID = 2;
                    _userService.Insert(user);

                    bool mail = MailHelper.ApprovedRegisterMail(user.Email);

                    if (!mail)
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Kayıt işlemi başarısız !" + ex.Message + " " + ex.InnerException;
                return View();
            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var currentUser = _userService.GetLogin(user.Email, user.Password);
            
            if (currentUser != null && currentUser.IsApproved != false)
            {
                if (currentUser.UserTypesID == 1)
                {
                    Session["admin"] = currentUser;
                    return RedirectToAction("Index", "Admin");
                }

                else if (currentUser.UserTypesID == 2)
                {
                    Session["user"] = currentUser;
                    return RedirectToAction("Index", "Home");
                }

                else if (currentUser.UserTypesID == 3)
                {
                    Session["modelist"] = currentUser;
                    return RedirectToAction("Index", "Home");
                }

                else
                {
                    return RedirectToAction("Register", "Account");
                }
            }
            ViewBag.Error = "Girilen bilgiler bir kullanıcıya ait değildir.";
            return View();
        }
    }
}