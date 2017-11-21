using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fpUploadEx.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                string path = "http://uploadex.somee.com/fpuploadex/images/" + file.FileName;
                file.SaveAs(path);
                return "OK";
            }
            else
            return "try again";
        }
    }
}