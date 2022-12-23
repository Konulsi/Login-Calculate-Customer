using Login_app.Helpers;
using ServiceLayer.Constants;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class Account : IAccount
    {
        public string Login(string email, string password, int roleId)
        {
            if (email == "test@code.edu.az" && password == "test12345" && roleId == (int)Roles.SuperAdmin)
            {
                return Errors.LoginSuccess; 
            }
            else if(roleId != (int)Roles.SuperAdmin) 
           {
                return Errors.LoginError;
            }
            else
            {
                return Errors.LoginMessage;
            }
        }

    }
}
