using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ROUTE.Controllers
{
    [RoutePrefix("Property")]
    public class PropertyController : Controller
    {
        [Route("BuyProperty/{value:int}")]
        public ActionResult Buy(int value)
        {
            ViewBag.Data = value;
            return View();
        }

        [Route("BuyProperty/{id}")]
        public ActionResult Sell(string id)
        {
            ViewBag.Data = id;
            return View();
        }

        [Route("RentProperty")]
        public ActionResult Rent()
        {
            return View();
        }
    }
}