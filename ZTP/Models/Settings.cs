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

        public int UpdateEveryMin { get; set; }
        public bool isUpdateEveryOn { get; set; }
        public bool SoundWhenActionWasSold { get; set; }
        public bool SoundWhenActionWasBought { get; set; }
        public bool SoundWhenPercentageWasChanged { get; set; }
        public bool SoundWhenEmailWasSend { get; set; }
        public bool NotificationAfterBought { get; set; }
        public bool NotificationAfterSold { get; set; }
        public bool NotificationAfterSendReport { get; set; }
        public bool NotificationAfterProvisionChanged { get; set; }
        public bool SummaryReport { get; set; }
        public bool SingleReporsts { get; set; }
        public string Email { get; set; }

        public virtual User User { get; set; }
    }
}
