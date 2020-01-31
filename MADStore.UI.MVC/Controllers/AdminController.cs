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
    public class AdminController : Controller
    {
        UserService _userService;

        public AdminController(UserService userService)
        {
            _userService = userService;
        }

        public ActionResult Index()
        {
            List<User> users = _userService.GetNotApprovedUser().ToList();

            return View(Tuple.Create<List<User>, User>(users, _userService.Get(2)));
        }

        [HttpPost]
        public ActionResult Index(List<User> users, User user)
        {
            ModelistRegister(user);
           
            return View();
        }


        [HttpPost]
        public ActionResult Approve(int userID)
        {
            User user = _userService.Get(userID);

            user.IsApproved = true;
            _userService.Update(user);
            bool send = MailHelper.SendRegisterMail(user.Email);

            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public ActionResult DisApprove(int userID)
        {

            User user = _userService.Get(userID);


            _userService.Delete(user);

            return RedirectToAction("Index", "Admin");
        }

        public ActionResult ModelistRegister(User user)
        {
            try
            {
                if (_userService.IsRegisteredUser(user.Email) == null)
                {
                    user.UserTypesID = 3;
                    user.IsApproved = true;
                    _userService.Insert(user);

                    bool mail = MailHelper.SendRegisterMail(user.Email);

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
            return RedirectToAction("Index", "Admin");
        }
    }
}