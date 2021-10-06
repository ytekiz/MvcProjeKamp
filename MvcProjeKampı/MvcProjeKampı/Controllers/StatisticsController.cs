using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampı.Controllers
{
    public class StatisticsController : Controller
    {
        Context _Context = new Context();
        // GET: Statistics
        public ActionResult Index()
        {
            var result1 = _Context.Categories.Count().ToString();
            ViewBag.result1 = result1;

            ViewBag.result2 = _Context.Headings.Count(c => c.CategoryID == 5);


            var result3 = (from c in _Context.Writers select c.WriterName.ToLower().IndexOf("a")).Count().ToString();
            ViewBag.result3 = result3;

            var result4 = _Context.Categories.Where(x => x.CategoryID == _Context.Headings.GroupBy(c => c.CategoryID).OrderByDescending(c => c.Count()).Select(c => c.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.result4 = result4;

          

            return View();
        }
    }
}