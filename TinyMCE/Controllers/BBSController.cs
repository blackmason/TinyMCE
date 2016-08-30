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

        public void UploadImages(HttpPostedFileBase image)
         {
            string fileName;
            string filePath;

            if (image.ContentLength > 0)
            {
                fileName = Path.GetFileName(image.FileName);
                filePath = Path.Combine(Server.MapPath("/Uploads/Images"), fileName);
                image.SaveAs(filePath);
            }

            //return RedirectToAction("OpenImages");
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
