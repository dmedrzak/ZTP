using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.Properties;

namespace ZTP.Models
{
   public class User
   {
        [Key]
       public int Id { get; set; }
       public string Login { get; set; }
       public string Password { get; set; }
       public DateTime CreateDate { get; set; }
       public bool isRemember { get; set; }


        public virtual Setting Settings { get; set; }
        public virtual VirtualWallet VirtualWallet { get; set; }
   }
}
