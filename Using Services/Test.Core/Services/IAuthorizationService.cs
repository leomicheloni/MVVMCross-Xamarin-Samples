using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Services
{
    public interface IAuthorizationService
    {
        bool AuthorizeUser(string userName, string password);

        bool IsLogged { get; set; }
    }
}
