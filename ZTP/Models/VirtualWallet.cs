using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.Models
{
    public class VirtualWallet
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }
        public decimal PaidMoney { get; set; }
        public decimal ActualAccountBalance { get; set; }

        public virtual User User { get; set; }
    }
}
