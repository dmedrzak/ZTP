using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.Models;

namespace ZTP.Controllers
{
    public class ValidatorController
    {
        public Error error;

        public ValidatorController()
        {
            this.error = new Error(); 
        }
        public bool ValidatePasswords(string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
               
                error.RegisterErrorMsg = "ERROR - Passwords are not equal. Enter correct passwords.";
                return false;
            }
            else
            {
                return true;
            }           
            //return password == confirmPassword ? true : false;
        }

        public bool ValidateIsLoginExists(string login)
        {
            using(var ctx = new dbContext())
            {
                var user = ctx.Users.FirstOrDefault(x => x.Login == login);

                if (user != null)
                {
                    error.RegisterErrorMsg = $"Error - User with login: {login} already exists.";
                    return true;
                }
                else
                {
                    
                    return false;
                }
            }
        }

    }
}
