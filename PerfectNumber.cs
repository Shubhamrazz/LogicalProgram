using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    //Explanation
    /*Perfect Number is just like the Armstrong number, the Perfect Number is also a special type of positive number.
     *When the number is equal to the sum of its positive divisors excluding the number, it is called a Perfect Number. 
     *For example, 28 is the perfect number because when we sum the divisors of 28, it will result in the same number.
      The divisors of 28 are 1, 2, 4, 7, and 14. So,
                        28 = 1+2+4+7+14 Then,28 = 28*/
    class PerfectNumber
    {
        public static int num, sum = 0;
        public static void CheckPerfectNumber()
        {
            Console.WriteLine("Enter a number to check wheather it is perfect number:");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(num + " is not a Perfect Number");
            }
        }
    }
}
