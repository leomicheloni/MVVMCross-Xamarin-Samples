using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private bool isLogged;

        public bool IsLogged
        {
            get
            {
                return this.isLogged;
            }
            set
            {
                this.isLogged = value;
            }
        }

        public bool AuthorizeUser(string userName, string password)
        {
            if (userName != "leo") return false;
            return true;
        }
    }
}
