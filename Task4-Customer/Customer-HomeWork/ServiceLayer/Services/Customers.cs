using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class Customers : ICustomers
    {
        public int GetCustomersAgeAverage(Customer[] arr)
        {
            int count = 0;

            foreach (var item in arr)
            {
                if (item.Age > 25 && item.Age < 30)
                {
                    count++;   
                }
            }
            return count;
        }



        public int GetCustomersAgeCount(Customer[] arr)
        {
            int sum = 0;
            int count = 0;
            foreach (var item in arr)
            {

                count++;
                sum += item.Age;
            }

            return sum / count;

        }
    }
}
