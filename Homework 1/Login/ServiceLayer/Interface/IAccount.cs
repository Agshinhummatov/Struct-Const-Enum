using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    internal interface IAccount
    {
        void Login(string email, string password,int roles);
    }
}
