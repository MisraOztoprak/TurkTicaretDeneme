using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurkTicaretCRM.Core.Entities;

namespace TurkTicaretCRM.Core.DataAccess
{
    public interface IQueryableRepository<T> where T:class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
