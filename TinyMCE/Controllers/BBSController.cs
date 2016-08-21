using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TinyMCE.Models.Helpers;

namespace TinyMCE.Controllers
{
    public class BBSController : Controller
    {
        //
        // GET: /BBS/

        public ActionResult Default()
        {
            return View();
        }

        public ActionResult OpenImages()
        {
            return View("OpenImages");
        }

        public void UploadImages(HttpPostedFileBase img)
        {
            string fileName;
            string filePath;
            if (img.ContentLength > 0)
            {
                fileName = Path.GetFileName(img.FileName);
                filePath = Path.Combine(Server.MapPath("/Uploads/Images"), fileName);
                img.SaveAs(filePath);
            }
        }

        [ValidateInput(false)]
        public ActionResult OnSubmit(string category, string subject, string contents)
        {
            BbsDataAccessHelper helper = new BbsDataAccessHelper();
            int result = helper.OnSubmit(category, subject, contents);

            return RedirectToAction("Default");
        }
    }
}
