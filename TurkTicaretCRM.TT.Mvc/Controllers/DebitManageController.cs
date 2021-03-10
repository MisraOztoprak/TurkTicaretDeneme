using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurkTicaretCRM.TT.Bussiness.Abstract;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.Mvc.Controllers
{
    public class DebitManageController : Controller
    {
        IDebitActivityService _debitActivityService;
        ICustomerDebitService _customerDebitService;
        IDebitService _debitService;

        public DebitManageController(IDebitActivityService debitActivityService, ICustomerDebitService customerDebitService, IDebitService debitService)
        {
            _debitActivityService = debitActivityService;
            _customerDebitService = customerDebitService;
            _debitService = debitService;
        }
        // GET: DebitManage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DebitManage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDebit(CustomerDebit customerDebit)
        {
            customerDebit.CustomerDebitStatus = true;
            customerDebit.RegistrationDate = DateTime.Now;
            customerDebit.UpdateDate = DateTime.Now;
            var result = _customerDebitService.Add(customerDebit);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAllDebitsByCustomerId(int id) {
            var result = _customerDebitService.GetDebitsByCustomerId(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateCustomerDebitWithActivity(DebitActivity activity)
        {
            _debitActivityService.Add(activity);
            var result = _customerDebitService.UpdateWithActivity(activity);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}