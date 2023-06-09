using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_10.Controllers
{
    public class Test02Controller : Controller
    {
        // GET: Test02
        public ActionResult Index()
        {
            return View();
        }
        public ContentResult ContentDemo()
        {
            return Content("This is a ContentResult example.");
        }

        public FileContentResult FileContentDemo()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/example.txt"));
            string fileName = "example.txt";
            return File(fileBytes, "text/plain", fileName);
        }

        public EmptyResult EmptyDemo()
        {

            return new EmptyResult();
        }

        public JavaScriptResult JavaScriptDemo()
        {
            string script = "alert('JavaScriptResult .');";
            return JavaScript(script);
        }

        public JsonResult JsonDemo()
        {
            var data = new { Name = "Akash", Age = 24 };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}