using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    //Explanation
    /*Armstrong Number
     *  A number is thought of as an Armstrong number if the sum of its own digits raised to the power number of digits gives the number itself.
     *  For example, 0, 1, 153, 370, 371, 407 are three-digit Armstrong numbers and, 
     *  1634, 8208, 9474 are four-digit Armstrong
     *  eg..407                         eg..9474
            =(4*4*4)+(0*0*0)+(7*7*7)          =(9*9*9*9)+(4*4*4*4)+(7*7*7*7)+(4*4*4*4)
            =64+0+343                         =6561+256+2401+256
            =407                              =9474
     */
    class ArmstrongNumber
    {
        public static void ArmsNumb()
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter the number for arms:");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not Armstrong Number");
        }
    }
}
