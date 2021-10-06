using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampı.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        IAuthService authService = new AuthManager(new WriterManager(new EfWriterDal()));
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult WriterRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WriterRegister(WriterLoginDto writerLoginDto)
        {
            authService.WriterRegister(writerLoginDto.WriterEmail, writerLoginDto.WriterPassword);
            return RedirectToAction("WriterLogin", "Login");
        }
    }
}