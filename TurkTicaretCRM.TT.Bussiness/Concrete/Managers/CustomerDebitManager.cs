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
    public class CustomerDebitManager : ICustomerDebitService
    {
        private ICustomerDebitDal _customerDebitDal;
        public CustomerDebitManager(ICustomerDebitDal customerDebitsDal)
        {
            _customerDebitDal = customerDebitsDal;
        }

        public CustomerDebit Add(CustomerDebit customerDebir)
        {
            return _customerDebitDal.Add(customerDebir);
        }

        public CustomerDebit GetById(int id)
        {
            return _customerDebitDal.Get(x => x.CustomerDebitID == id);
        }

        public List<CustomerDebit> GetDebitsByCustomerId(int id)
        {
            return _customerDebitDal.GetList(x => x.CustomerID == id);
        }

        public CustomerDebit UpdateWithActivity(DebitActivity activity)
        {
            var customerDebit = _customerDebitDal.Get(x => x.CustomerDebitID == activity.CustomerDebitID);
            customerDebit.DebitTotal = customerDebit.DebitTotal - activity.DiscountTotal;
            if (customerDebit.DebitTotal == 0)
            {
                customerDebit.CustomerDebitStatus = false;
            }
            else if (customerDebit.DebitTotal < 0) {
                throw new Exception("Toplam kalan borçtan fazla aktivite girilmez");
            }
            customerDebit.UpdateDate = DateTime.Now;
            return _customerDebitDal.Update(customerDebit);
        }

    }
}
