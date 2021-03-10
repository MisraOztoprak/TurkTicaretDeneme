using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.Bussiness.Abstract
{
    public interface IDebitActivityService
    {
        List<DebitActivity> GetAll();
        DebitActivity GetById(int id);
        DebitActivity Add(DebitActivity debitActivity);
    }
}
