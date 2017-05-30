using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.Models;

namespace ZTP.Controllers
{
    public sealed class CurrentLoggedUser
    {
        private User _user;
        private static CurrentLoggedUser _instance=null;
        private static readonly object padlock = new object();
        public static CurrentLoggedUser Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new CurrentLoggedUser();
                        }
                    }
                }
                return _instance;
            }
        }

        private CurrentLoggedUser()
        {
        }

        public void SetLoggedUser(User user)
        {
            this._user = user;
        }

        public User GetLoggedUser()
        {
            return this._user;
        }

        public string GetUserName()
        {
            return _user.Login;
        }
    }
}
