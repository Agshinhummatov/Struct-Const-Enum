using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Helpers.Enums
{
    public struct Errors
    {

        public const string EmailNotFound = "Email and Password not found";
        public const string SuperAdmin = " Welcome Super Admin ";
        public const string NotSuperAdmin = "You are not Super Admin";
    }
}
