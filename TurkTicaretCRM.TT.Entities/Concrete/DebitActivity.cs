using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTicaretCRM.Core.Entities;

namespace TurkTicaretCRM.TT.Entities.Concrete
{
    public class DebitActivity:IEntity
    {
        [Key]
        public int DebitActivityID { get; set; }
        public int CustomerDebitID { get; set; }
        public virtual CustomerDebit CustomerDebit { get; set; }
        public string Comment { get; set; }
        public int DiscountTotal { get; set; }
        public DateTime ActivityDate { get; set; }

    }
}
