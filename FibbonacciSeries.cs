using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{ 
        //Explanation
    /*Fibonacci series is a special type of series in which the next term is the sum of the
          previous two terms. For example, if 0 and 1 are the two previous terms in a series, then
          the next term will be 1(0+1).*/
    class FibbonacciSeries
    {
        public static void FibboNum()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter the number for fibbo:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2 + " ");//here printing 0 and 1
            for (i = 2; i < number; i++)//FOR LOOP WILL BE STARTING FROM 2 BECOZ 0 1 ALREADY PRINTED
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + "");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
