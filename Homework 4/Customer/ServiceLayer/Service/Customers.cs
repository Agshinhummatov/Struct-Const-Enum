using DomainLayer.Models;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class Customers : ICostumer
    {
        public double GetAge( Customer [] ages)
        {


            int count = 0;
            foreach (var item in ages)
            {

                if (item.Age > 25 && item.Age < 30)
                {
                    count++;
                }

            }   

            return count;

      
        }



        
    }
}
