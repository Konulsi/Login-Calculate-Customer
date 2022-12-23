using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InClassTask.Helpers
{
    public static class Extention
    {
        public static bool GetNum(this int a, int b, int c )
        {
            
            
                if (a > b && a< c)
                {
                return true;    
                }
            return false;   
 
            
            

        }




        public static double GetNumPower(this int [] arr,int power )
        {
            int sum = 0;


            foreach (var item in arr)
            {
                sum+=item;
            }
            return Math.Pow(sum ,power );
              
        }
    }
}
