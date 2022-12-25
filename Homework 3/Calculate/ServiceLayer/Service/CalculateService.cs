using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class CalculateService : ICalculateService
    {
        int result = 1;
        public int Calculate(int[] arr)
        {
            int result = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 20 && arr[i] > 1)
                {
                    result = arr[i] * result;

                }
            }
            return result;   
          
        }

        public int CalculatePower(int[] arr)
        {
            
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 ==0)
                {
                    
                    sum = sum + arr[i];
                }
          
          
            }

            sum = sum * sum;
            return sum;
        }


    }
}
