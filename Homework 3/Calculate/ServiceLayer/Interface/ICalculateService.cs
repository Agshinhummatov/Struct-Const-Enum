using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface ICalculateService
    {

        int Calculate(int[] arr);

        int CalculatePower(int[] arr);


    }
}
