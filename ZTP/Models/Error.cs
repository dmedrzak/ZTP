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
    public class Error : INotifyPropertyChanged
    {
        private string registerError;
        private string loginError;
        public string RegisterErrorMsg
        {
            get { return this.registerError; }
            set
            {
                registerError = value;
                OnPropertyChanged("registerError");
            }
        }

        public string LoginErrorMsg
        {
            get { return this.loginError; }
            set
            {
                loginError = value;
                OnPropertyChanged("LoginErrorMsg");
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
