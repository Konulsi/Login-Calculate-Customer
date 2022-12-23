using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICalculateService
    {
        int GetArrNumsMultiple(int[] arr);

        double GetArrNumsSumPow(int[] arr,int power);
    }
}
