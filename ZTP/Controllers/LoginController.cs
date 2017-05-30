using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.Models;

namespace ZTP.Controllers
{
    public class LoginController
    {
        public Error msg = new Error();
        private ValidatorController validator = new ValidatorController();
        SettingsController settingsController = new SettingsController();
        public void LoginUser(string login, string password)
        {
            using (var ctx = new dbContext())
            {
                if (validator.ValidateIsLoginExists(login))
                {
                    SignIn(login, password);
                }
            }         
        }

        public bool SignIn(string login, string password)
        {
            using (var ctx = new dbContext())
            {
                var user = ctx.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
                if (user != null)
                {
                    CurrentLoggedUser.Instance.SetLoggedUser(user);
                    WriteUserToXml.SaveUserInXml(user);
                    settingsController.LoadSettings();
                    msg.LoginErrorMsg = "User succesfully logged in.";
                    return true;
                }
                else
                {
                    msg.LoginErrorMsg = "Login or password are wrong.";
                    return false;
                }
            }
        }



        public void IsRememberedLogin(User user)
        {
            // SAVE XML FILE WITH USER INFORMATION
        }
    }
}
