using i18n;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STIFE.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult SetLanguage(string langtag, string returnUrl)
        {
            //if valid "langtag" passed
            i18n.LanguageTag lt = i18n.LanguageTag.GetCachedInstance(langtag);
            if (lt.IsValid())
            {
                //Set persistent coockie in the client to remember the language choice.
                Response.Cookies.Add(
                    new HttpCookie("i18n.langtag")
                    {
                        Value = lt.ToString(),
                        HttpOnly = true,
                        Expires = DateTime.UtcNow.AddYears(1)
                    });
            }
            //delete any language coockie in the client.
            else
            {
                var coockie = Response.Cookies["i18n.langtag"];
                if (coockie != null)
                {
                    coockie.Value = null;
                    coockie.Expires = DateTime.UtcNow.AddMonths(-1);
                }
            }

            System.Web.HttpContext.Current.SetPrincipalAppLanguageForRequest(lt);
            //if(returnUrl.IsSet())
            //{
            //    returnUrl = LocalizedApplication.Current.UrlLocalizerForApp.SetLangTagInUrlPath(HttpContext, returnUrl, UriKind.RelativeOrAbsolute, lt == null ? null : lt.ToString()).ToString();
            //}

            return Redirect(returnUrl);
        }
    }
}