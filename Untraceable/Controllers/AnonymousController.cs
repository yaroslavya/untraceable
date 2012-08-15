using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Untraceable.Common;

namespace Untraceable.Controllers
{
    /// <summary>
    /// All the reposonses of this controller should be anonymous in terms of 
    /// technology, like asp.net version, server etc.
    /// </summary>
    [NoHeadersFilter]
    public class AnonymousController : Controller
    {
        //
        // GET: /Anonymous/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AlsoUntraceable()
        {
            return View();
        }

    }
}
