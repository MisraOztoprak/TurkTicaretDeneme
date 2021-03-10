using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurkTicaretCRM.TT.Bussiness.Abstract;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.Mvc.Controllers
{
    public class DebitTypeController : Controller
    {
        IDebitService _debitService;
        public DebitTypeController(IDebitService debitService)
        {
            _debitService = debitService;
        }
        // GET: DebitType
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult DebitTypeManage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDebitType(Debit debit)
        {
            var result = _debitService.Add(debit);
            return Json(result);
        }

        public ActionResult GetAllDebits()
        {
            var result = _debitService.GetAll();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}