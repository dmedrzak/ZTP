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
        private bool _soundWhenActionWasSold { get; set; }
        private bool _soundWhenActionWasBought { get; set; }
        private bool _soundWhenEmailWasSend { get; set; }
        private bool _soundWhenPercentageWasChanged { get; set; }
        private bool _notificationAfterBought { get; set; }
        private bool _notificationAfterSold { get; set; }
        private bool _notificationAfterReports { get; set; }
        private bool _notificationAfterProvisionChanged { get; set; }

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
            get { return this._soundWhenActionWasSold; }
            set
            {
                _soundWhenActionWasSold = value;
                OnPropertyChanged("SoundWhenActionWasSoldNotification");
            }
        }
        public bool SoundWhenActionWasBoughtNotification
        {
            get { return this._soundWhenActionWasBought; }
            set
            {
                _soundWhenActionWasBought = value;
                OnPropertyChanged("SoundWhenActionWasBoughtNotification");
            }
        }
        public bool SoundWhenEmailWasSendNotification
        {
            get { return this._soundWhenEmailWasSend; }
            set
            {
                _soundWhenEmailWasSend = value;
                OnPropertyChanged("SoundWhenEmailWasSendNotification");
            }
        }
        public bool SoundWhenPercentageWasChangedNotification
        {
            get { return this._soundWhenPercentageWasChanged; }
            set
            {
                _soundWhenPercentageWasChanged = value;
                OnPropertyChanged("SoundWhenPercentageWasChangedNotification");
            }
        }
        public bool NotificationAfterBought
        {
            get { return this._notificationAfterBought; }
            set
            {
                _notificationAfterBought = value;
                OnPropertyChanged("NotificationAfterBought");
            }
        }
        public bool NotificationAfterSold
        {
            get { return this._notificationAfterSold; }
            set
            {
                _notificationAfterSold = value;
                OnPropertyChanged("NotificationAfterSold");
            }
        }
        public bool NotificationAfterSendReports
        {
            get { return this._notificationAfterReports; }
            set
            {
                _notificationAfterReports = value;
                OnPropertyChanged("NotificationAfterSendReports");
            }
        }
        public bool NotificationAfterProvisionChanged
        {
            get { return this._notificationAfterProvisionChanged; }
            set
            {
                _notificationAfterProvisionChanged = value;
                OnPropertyChanged("NotificationAfterProvisionChanged");
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
