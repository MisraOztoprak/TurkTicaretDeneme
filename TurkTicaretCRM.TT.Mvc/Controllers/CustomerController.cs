using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurkTicaretCRM.TT.Bussiness.Abstract;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.Mvc.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerManage()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CustomerProfile(string id)
        {
            Customer result = _customerService.GetById(int.Parse(id));
            ViewData.Add("Customer", result);
            return View();
        }

        public ActionResult GetAllCustomers()
        {
            var result = _customerService.GetAll();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            customer.RegistrationDate = DateTime.Now;
            customer.UpdateDate = DateTime.Now;
            var result = _customerService.Add(customer);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult DeleteCustomer(string id)
        {
            var result = _customerService.DeleteById(int.Parse(id));
            return Json(result);
        }

    }
}