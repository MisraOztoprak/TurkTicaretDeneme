using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurkTicaretCRM.TT.Bussiness.Abstract;

namespace TurkTicaretCRM.TT.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerService _customerService;

        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllCustomer()
        {
            var result = _customerService.GetById(1).CustomerID;
            return Json(result, JsonRequestBehavior.AllowGet);
        }


    }
}