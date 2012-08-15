using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Untraceable.Common
{
    public class NoHeadersFilter : ActionFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if (HttpRuntime.UsingIntegratedPipeline)
            {
                filterContext.HttpContext.Response.Headers.Remove("Server");
                filterContext.HttpContext.Response.Headers.Remove("Date");
            }
            else
            {
                filterContext.HttpContext.Response.AddHeader(">", ">");
            }

            base.OnResultExecuted(filterContext);
        }
    }
}