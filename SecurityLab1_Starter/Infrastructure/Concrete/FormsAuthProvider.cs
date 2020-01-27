using SecurityLab1_Starter.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SecurityLab1_Starter.Infrastructure.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        //bool Authenticate
        public bool Authenticate(string username, string password)
        {
            bool result = FormsAuthentication.Authenticate(username, password);
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
             
        }

        /*

        public bool Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        FormsAuthProvider.Authentication(username, password)
        */
    }
}