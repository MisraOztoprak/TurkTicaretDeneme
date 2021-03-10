using System;
using System.Collections.Generic;
using System.Text;
using TurkTicaretCRM.Core.DataAccess;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
