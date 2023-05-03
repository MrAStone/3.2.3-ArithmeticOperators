using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._3_ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add two integers
            int num1,num2;
            num1 = 12; num2 = 13;
            int num3 = num1 + num2;
            Console.WriteLine(num3);    
            //add two decimals
            double dNum1, dNum2;
            dNum1 = 3.1596;
            dNum2 = 9.3642;
            double dNum3 = dNum1 + dNum2;  
            Console.WriteLine(dNum3);

        }
    }
}
