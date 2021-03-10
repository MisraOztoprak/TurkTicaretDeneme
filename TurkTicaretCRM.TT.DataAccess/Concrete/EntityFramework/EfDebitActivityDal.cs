using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTicaretCRM.Core.DataAccess.EntityFramework;
using TurkTicaretCRM.TT.DataAccess.Abstract;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.DataAccess.Concrete.EntityFramework
{
    public class EfDebitActivityDal:EfEntityRepositoryBase<DebitActivity, TTContext>, IDebitActivityDal
    {
    }
}
