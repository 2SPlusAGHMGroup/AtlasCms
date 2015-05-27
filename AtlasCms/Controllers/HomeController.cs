using BasicModels;
using DataLayer.Context;
using System;
using System.Web.Mvc;

namespace AtlasCms.Controllers
{
    public class HomeController : Controller
    {
        private AtlasCmsContext oContext = new AtlasCmsContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            try
            {
                Country Cnt = new Country(98, "ایران", "Iran", null);
                oContext.Countries.Add(Cnt);
                oContext.SaveChanges();
                ViewBag.Message = Cnt.Id.ToString() + " ** " + Cnt.Name;
            }
            catch (Exception Err)
            {
                ViewBag.Message = Err.Message;
            }
            return View();
        }

        public ActionResult AboutMe() {
            return View();
        }
    }
}