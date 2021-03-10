using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.Bussiness.Abstract
{
    public interface IDebitService
    {
        Debit GetById(int id);
        List<Debit> GetAll();
        Debit Add(Debit debit);
    }
}
