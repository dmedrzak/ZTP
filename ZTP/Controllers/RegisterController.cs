using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.Models;

namespace ZTP.Controllers
{
    public class RegisterController
    {
        public Error msg = new Error();
        public void RegisterUser(string login, string password)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                User user = new User {Login = login, Password = password, CreateDate = DateTime.Now, isRemember = false};
                using (var ctx = new dbContext())
                {
                    try
                    {
                        ctx.Users.Add(user);
                        ctx.SaveChanges();
                        msg.RegisterErrorMsg = "Succesfully Register.";
                    }
                    catch
                    {
                        msg.RegisterErrorMsg = "Registration failed. Database Problems.";
                    }
                }
            }         
        }
    }
}
