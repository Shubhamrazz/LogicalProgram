using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{       //Explanation
    /*Prime Numberis just like the Perfect number, the Prime number is also a special type of number.
     * When the number is divided greater than 1 and divided by 1 or itself is referred to as the Prime number.
     * 0 and 1 are not counted as prime numbers. All the even numbers can be divided by 2, so 2 is the only even prime minister*/
    class PrimeNumber
    {
        public static void GetPrimeNumbers()
        {
            Console.WriteLine("Enter the range to print prime numbers within that range (a to b): ");
            Console.WriteLine("Enter the value of starting number (a): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of end number (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                int prime = 1;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        prime = 0;
                        break;
                    }
                }
                if (prime == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
