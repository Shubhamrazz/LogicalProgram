using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    //Explanation
    /*Reverse Number Using Loop
      a. We need to calculate the remainder of the number using the modulo
      b. After that, we need to multiply the variable reverse by 10 and add the remainder into it.
      c. We then divide the number by 10 and repeat steps until the number becomes 0.*/
    class ReverseNumber
    {
        public static void GetReverseNumber()
        {
            int reminder, reverse = 0;
            Console.WriteLine("Please Enter Number to reverse:");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;
            }
            Console.WriteLine(reverse);

            Console.ReadLine();
        }
    }
}
