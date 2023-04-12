using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public static class Calculator
    {
        public static int Add(int a, int b)
        {
         return a + b;
        }
    public static int subtract(int a, int b)
    {
    return a - b;
    }
    public static double divide(int a, int b)
    {
         if(a == 0 || b == 0)
            {
                throw new SystemException($"{b==0} || {a==0}-tak nelza");
            }
    return (double)a / (double)b;
    }
    public static int multiply(int a,int b)
    {
    return a * b;
    }
  
    }
}
