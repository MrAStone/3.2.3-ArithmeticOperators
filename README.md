```c#
using System;
using System.CodeDom;
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
            // addition
            //Add two integers
            int num1, num2;
            num1 = 12; num2 = 13;
            int num3 = num1 + num2;
            Console.WriteLine(num3);
            //add two decimals
            double dNum1, dNum2;
            dNum1 = 3.1596;
            dNum2 = 9.3642;
            double dNum3 = dNum1 + dNum2;
            Console.WriteLine(dNum3);
            // Add different numerical data types
            dNum3 = dNum3 + num3;
            Console.Write(dNum3);
            // num3 = dNum1 + num2; will error as result would be double not integer

            // subtraction
            // Subtract two integers
            num3 = num1 - num2;
            Console.WriteLine(num3);
            //subtract two decimals
            dNum3 = dNum1 - dNum3;
            Console.WriteLine(dNum3);
            //subtract different numerical data types
            dNum3 = num1 - dNum2;
            Console.WriteLine(dNum3);
            // num3 = dNum1 - num2;  will error as result would be double not integer

            // multiplication
            // integers
            num3 = num1 * num2;
            Console.WriteLine(num3);
            // decimals
            dNum3 = dNum1 * num2;
            Console.WriteLine(dNum3);
            // mixture
            dNum3 = num1 * dNum2;
            Console.WriteLine(dNum3);
            // num3 = dNum3 * num2;  will error as result would be double not integer

            // real division
            // Division in C# is based on the data type
            // To do real division the result must be stored in a decimal
            // The numbers used must also be stored in a decimal
            num1 = 7; num2 = 3;
            dNum3 = num1 / num2; // produces answer 2 as num1 and num2 are integers
            Console.WriteLine(dNum3);

            dNum1 = 7;
            dNum2 = 3;
            dNum3 = dNum1 / dNum2;
            Console.WriteLine(dNum3); // produces 2.333333.. which is correct decimal answer

            // If either number or divisor is decimal, a decimal will be produced

            dNum3 = dNum1 / num2;
            Console.WriteLine(dNum3);

            dNum3 = num1 / dNum2;
            Console.WriteLine(dNum3);

            // integer division, including remainders.
            // dividing two integers will produce integer division
            num1 = 9;
            num2 = 4;
            dNum3 = num1 / num2;
            Console.WriteLine(dNum3); // Produces 2 not 2.5
            Console.WriteLine(num1 / num2); // Also produces 2 as answer is integer
            //Finding remainder
            // Using MOD in c# uses the % symbol
            num3 = num1 % num2;
            Console.WriteLine(num3); // produces 1 as 9 / 4 has a remainder of 1 // 9 MOD 4 = 1

            // In C# the following is true
            // 11 / 2 = 5, 
            // 11 MOD 2 is written 11 % 2 = 1
            Console.WriteLine(11 / 2);
            Console.WriteLine(11 % 2);

        }
    }
}
```
