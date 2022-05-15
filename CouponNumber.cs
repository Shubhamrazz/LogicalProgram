using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    //Explanation
    /*Coupon Number..Logic
     a. Desc -> Given N distinct Coupon Numbers, how many random numbers do you need to generate a distinct coupon number?
        This program simulates this random process.
     b. I/P -> N Distinct Coupon Number
     c. Logic -> repeatedly choose a random number and check whether it's a new one.
     d. O/P -> total random number needed to have all distinct numbers.
     e. Functions => Write Class Static Functions to generate random numbers and to process distinct coupons.*/
    class CouponNumber
    {
        public static int[] distCouponNum = new int[4] { 11, 48, 7, 21 };
        public static Random random = new Random();
        public static int[] randomCount = new int[4];
        public static int totalCount = 0, i = 0;
        public static void CheckCouponNumbers()
        {
            foreach (var coupon in distCouponNum)
            {
                while (coupon != random.Next(0, 50))
                {
                    randomCount[i]++;
                    totalCount++;
                }
                Console.WriteLine("Random numbers generated to get " + coupon + " are: " + randomCount[i]);
                i++;
            }
            Console.WriteLine("Total random numbers generated to get all distinct numbers :" + totalCount);
        }
    }
}
