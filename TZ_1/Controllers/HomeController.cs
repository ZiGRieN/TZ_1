using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using NLog;

namespace TZ_1.Controllers
{
    public class HomeController : Controller
    {
        AdresaDBEntities e = new AdresaDBEntities();
        private static Logger logger = LogManager.GetCurrentClassLogger();

       public ActionResult Index()
        {
            log();
            return View();
        }
       public void log()
  {
      logger.Trace("Sample trace message");
      logger.Debug("Sample debug message");
      logger.Info("Sample informational message");
      logger.Warn("Sample warning message");
      logger.Error("Sample error message");
      logger.Fatal("Sample fatal error message");
      logger.Log(LogLevel.Info, "Sample informational message");
  }
        //e.Addresses.ToList()
       /* public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/

     /*  public IEnumerable<Addresses> GetAdres()
       {
           AdresaEntities e = new AdresaEntities();
           var s = from p in e.Addresses.AsEnumerable() select p;
           return s;
       }*/
       
     /* public JsonResult GetAdres()
       {
           AdresaDBEntities e = new AdresaDBEntities();
           //var result = e.Addresses.ToList();
           var result = e.Addresses.Select(x => new {Id = x.Id, Country = x.Country.Country1, City = x.City1.City1, Street = x.Street1.Street1, House = x.House, Indeks = x.Indeks, Data = x.Data }).ToList();
           return Json(result,JsonRequestBehavior.AllowGet);
        
       }*/
     
       
       /* public ActionResult GetAdres()
        {
            AdresaDBEntities e = new AdresaDBEntities();
            //var result = e.Addresses.ToList();
            var data = e.Addresses.Include(p => p.Country);
            var result = data.ToList();
            return View(result);
        }*/
      /*public IEnumerable<Addresses> GetAdres() 
       {
           return e.Addresses.AsEnumerable();
       }*/
    }
}