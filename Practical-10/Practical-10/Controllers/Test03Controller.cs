using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_10.Controllers
{
    public class Test03Controller : Controller
    {
        // GET: Test03
        [OutputCache(Duration = 300, VaryByParam = "*")]
        public ActionResult CurrentDateTime()
        {
            return View(DateTime.Now);
        }
    }
}