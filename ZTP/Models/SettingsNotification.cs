using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ZTP.Annotations;

namespace ZTP.Models
{
    public class SettingsNotification : INotifyPropertyChanged
    {
        private bool isUpdatenEvery;
        private string updateEveryMinuts = "30";
        private bool soundWhenActionWasSold { get; set; }
        private bool soundWhenActionWasBought { get; set; }
        private bool soundWhenEmailWasSend { get; set; }
        private bool soundWhenPercentageWasChanged { get; set; }
        public bool SwitchUpdateEveryMinNotification
        {
            get { return this.isUpdatenEvery; }
            set
            {
                isUpdatenEvery = value;
                OnPropertyChanged("SwitchUpdateEveryMinNotification");
            }
        }
        public string IsUpdateEveryMinutesNotification
        {
            get { return this.updateEveryMinuts; }
            set
            {
                updateEveryMinuts = value;
                OnPropertyChanged("IsUpdateEveryMinutesNotification");
            }
        }
        public bool SoundWhenActionWasSoldNotification
        {
            get { return this.soundWhenActionWasSold; }
            set
            {
                soundWhenActionWasSold = value;
                OnPropertyChanged("SoundWhenActionWasSoldNotification");
            }
        }
        public bool SoundWhenActionWasBoughtNotification
        {
            get { return this.soundWhenActionWasBought; }
            set
            {
                soundWhenActionWasBought = value;
                OnPropertyChanged("SoundWhenActionWasBoughtNotification");
            }
        }
        public bool SoundWhenEmailWasSendNotification
        {
            get { return this.soundWhenEmailWasSend; }
            set
            {
                soundWhenEmailWasSend = value;
                OnPropertyChanged("SoundWhenEmailWasSendNotification");
            }
        }
        public bool SoundWhenPercentageWasChangedNotification
        {
            get { return this.soundWhenPercentageWasChanged; }
            set
            {
                soundWhenPercentageWasChanged = value;
                OnPropertyChanged("SoundWhenPercentageWasChangedNotification");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
