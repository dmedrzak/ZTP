using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.Models
{
    public class Setting
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }
        public string Email { get; set; }

        public virtual User User { get; set; }
    }
}
