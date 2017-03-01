using System.Web;
using System.Web.Mvc;

namespace STIFE.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new NoCacheGlobalActionFilter());
        }
    }

    public class NoCacheGlobalActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionDescriptor.GetCustomAttributes(typeof(OutputCacheAttribute), false).Length > 0)
                return;

            HttpCachePolicyBase cache = filterContext.HttpContext.Response.Cache;
            cache.SetCacheability(HttpCacheability.NoCache);
            base.OnActionExecuting(filterContext);
        }
    }
}