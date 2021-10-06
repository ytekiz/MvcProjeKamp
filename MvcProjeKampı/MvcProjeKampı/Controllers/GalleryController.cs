using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampı.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageFileManager ifm = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var files = ifm.GetList();
            return View(files);
        }
        [HttpPost]
        public ActionResult AddImage(HttpPostedFileBase ımage)
        {
            if (ımage.ContentLength > 0)
            {
                string dosyayolu = Path.Combine(Server.MapPath("/Images/"), Path.GetFileName(ımage.FileName));
                ımage.SaveAs(dosyayolu);
            }
            return RedirectToAction("Index");
        }
    
    }
}