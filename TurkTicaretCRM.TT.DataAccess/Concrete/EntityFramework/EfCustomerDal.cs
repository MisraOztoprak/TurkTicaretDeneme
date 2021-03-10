using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TurkTicaretCRM.Core.DataAccess.EntityFramework;
using TurkTicaretCRM.TT.DataAccess.Abstract;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, TTContext>,ICustomerDal
    {
    }
}
