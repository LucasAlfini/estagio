using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LFSoftWeb.Filters
{
    public class AcessoRestritoFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Ocorre depois da execução da Action

            //throw new NotImplementedException();
            string x = "Action já executada...";
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Ocorre antes da execução da Action

            var controllerName = (string)filterContext.RouteData.Values["controller"];
            var actionName = (string)filterContext.RouteData.Values["action"];
            var hostAddress = filterContext.HttpContext.Request.UserHostAddress;

            if (filterContext.HttpContext.Session["autenticado"] == null ||
                    filterContext.HttpContext.Session["autenticado"].ToString() != "ok")
            {
                filterContext.Result = new RedirectResult("~/Admin/Usuario/Autenticar");
            }
        }
    }
}