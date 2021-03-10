using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTicaretCRM.Core.Entities;

namespace TurkTicaretCRM.TT.Entities.Concrete
{
    public class Debit:IEntity
    {
        [Key]
        public int DebitID { get; set; }
        public string DebitReason { get; set; }
    }
}
