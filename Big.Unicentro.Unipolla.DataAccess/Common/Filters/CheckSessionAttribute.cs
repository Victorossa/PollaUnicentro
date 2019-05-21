using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Big.Unicentro.Unipolla.DataAccess.Common.Helpers;

namespace Big.Unicentro.Unipolla.DataAccess.Common.Filters
{
    public class CheckSessionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (filterContext.ActionDescriptor.GetCustomAttributes(typeof(IgnoreCheckSessionAttribute), false).Any())
            {
                return;
            }
            if (!string.IsNullOrEmpty(SessionHelper.IdCurrentCustomer) && !string.IsNullOrEmpty(SessionHelper.IdCurrentCodesWinner)) return;

            ActionResult result;
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                result = new JavaScriptResult { Script = "window.location.replace('" + UrlHelper.GenerateContentUrl("~/", filterContext.HttpContext) + "');" };
            }
            else
            {
                SessionHelper.LimpiarSesion();
                result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Account" }, { "action", "Login" } });
            }

            filterContext.Result = result;
        }
    }

    public class IgnoreCheckSessionAttribute : ActionFilterAttribute
    {
    }
}