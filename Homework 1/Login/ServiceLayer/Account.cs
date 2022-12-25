using ServiceLayer.Helpers;
using ServiceLayer.Helpers.Enums;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class Account : IAccount
    {
        

        public void Login(string email, string password,int roles )
        {

            

            if (email == "test@code.edu.az" && password == "test12345" && roles == (int)Roles.SuperAdmin)
            {

                Console.WriteLine(Errors.SuperAdmin);


             }
            else if (email == "test@code.edu.az " && password == "test12345" && roles != (int)Roles.SuperAdmin)
            {

                Console.WriteLine(Errors.NotSuperAdmin);
            }
            else
            {
                Console.WriteLine(Errors.EmailNotFound);

            }
          
        }

       
    }
}
