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
        /// <summary>
        /// Этот метод делит
        /// </summary>
        /// <param name="a"> что делит </param>
        /// <param name="b"> на что делит (b!=0) </param>
        /// <returns> результат </returns>
        /// <exception cref="SystemException"> если b==0 </exception>
    public static double divide(int a, int b)
    {
         if( b == 0)
            {
                throw new System.ArgumentException($"{b==0}-tak nelza");
            }
    return (double)a / (double)b;
    }
    public static int multiply(int a,int b)
    {
    return a * b;
    }
  
    }
}
