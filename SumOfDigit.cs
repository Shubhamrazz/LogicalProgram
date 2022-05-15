using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class SumOfDigit
    {
        public static void Sum()
        {
            int summ = 0;
            Console.WriteLine("Enter the number for sumofdigit:");
            int actualNumber = Convert.ToInt32(Console.ReadLine());
            int num = actualNumber;
            while (num > 0)
            {
                summ += num % 10;
                num /= 10;
            }
            Console.WriteLine(summ);
        }
    }
}
