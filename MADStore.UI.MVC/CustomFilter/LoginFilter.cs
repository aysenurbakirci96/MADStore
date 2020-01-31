using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MADStore.UI.MVC.CustomFilter
{
    public class LoginFilter : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //Kullanıcı varken
            if (System.Web.HttpContext.Current.Session["kullanici"] != null)
            {
                return true;
            }
            return false;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //Kullanıcı girişi yok
            filterContext.Result = new RedirectResult("/Account/Login");
        }
    }
}