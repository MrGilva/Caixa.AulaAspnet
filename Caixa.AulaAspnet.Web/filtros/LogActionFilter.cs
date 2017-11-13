using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caixa.AulaAspnet.Web.filtros
{
    public class LogActionFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //[data/hora] Iniciou: {Controller}/{Action}
            string message = string.Format("Iniciou em: [{0}] - Processo(s): {1}/{2}", 
                            DateTime.Now, 
                            filterContext.RouteData.Values["Controller"].ToString(),
                            filterContext.RouteData.Values["Action"].ToString());

            Debug.WriteLine(message);
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //[data/hora] Iniciou: {Controller}/{Action}
            string message = string.Format("Terminou em: [{0}] - Processo(s): {1}/{2}",
                            DateTime.Now,
                            filterContext.RouteData.Values["Controller"].ToString(),
                            filterContext.RouteData.Values["Action"].ToString());

            Debug.WriteLine(message);
        }
    }
}