using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTicaretCRM.TT.Bussiness.Abstract;
using TurkTicaretCRM.TT.DataAccess.Abstract;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.Bussiness.Concrete.Managers
{
    public class DebitActivityManager : IDebitActivityService
    {
        IDebitActivityDal _debitActivityDal;
        public DebitActivityManager(IDebitActivityDal debitActivityDal)
        {
            _debitActivityDal = debitActivityDal;
        }
        public DebitActivity Add(DebitActivity debitActivity)
        {
            return _debitActivityDal.Add(debitActivity);
        }

        public List<DebitActivity> GetAll()
        {
            return _debitActivityDal.GetList();
        }

        public DebitActivity GetById(int id)
        {
            return _debitActivityDal.Get(x => x.DebitActivityID == id);
        }
    }
}
