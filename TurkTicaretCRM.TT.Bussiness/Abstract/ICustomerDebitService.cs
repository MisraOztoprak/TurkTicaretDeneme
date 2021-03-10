using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.Bussiness.Abstract
{
    public interface ICustomerDebitService
    {
        CustomerDebit GetById(int id);
        CustomerDebit Add(CustomerDebit customerDebir);
        List<CustomerDebit> GetDebitsByCustomerId(int id);

        CustomerDebit UpdateWithActivity(DebitActivity activity);
    }
}
