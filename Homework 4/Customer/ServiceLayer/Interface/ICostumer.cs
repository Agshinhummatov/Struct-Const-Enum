using DomainLayer.Models;
using ServiceLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface ICostumer
    {

        double GetAge(Customer [] ages);

    }


    
}
