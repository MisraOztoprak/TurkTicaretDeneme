using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTicaretCRM.Core.Entities;

namespace TurkTicaretCRM.TT.Entities.Concrete
{
    public class CustomerDebit:IEntity
    {
        [Key]
        public int CustomerDebitID { get; set; }
        public virtual int CustomerID { get; set; }
        public virtual int  DebitID { get; set; }
        public Customer Customer { get; set; }
        public Debit Debit { get; set; }
        public string DebitReason { get; set; }
        public int DebitTotal { get; set; }
        public bool CustomerDebitStatus { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
