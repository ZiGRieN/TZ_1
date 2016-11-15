using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TZ_1.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
       /* AdresaEntities e = new AdresaEntities();
        public ActionResult Index()
        {
            return View();
        }
        //e.Addresses.ToList()
        public JsonResult GetAdres() 
        {
            
            var result = e.Addresses.ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }*/
       /* public IEnumerable<Addresses> GetAdres() 
        {
            AdresaEntities e = new AdresaEntities();
            var s = from p in e.Addresses.AsEnumerable() select p;
            return s;
        }*/
        public JsonResult GetAdres()
        {
            AdresaDBEntities e = new AdresaDBEntities();
            var result = e.Addresses.ToList();
            
            return Json(result, JsonRequestBehavior.AllowGet);

        }
    }
}