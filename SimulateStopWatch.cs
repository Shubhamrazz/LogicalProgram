using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalProgram
{
    //Explanation
    /*Simulate Stop Watch Program Logic
    a. Desc -> Write a Stopwatch Program for measuring the time that elapses between the start and end clicks
    b. I/P -> Start the Stopwatch and End the Stopwatch
    c. Logic -> Measure the elapsed time between start and end
    d. O/P -> Print the elapsed time. */
    class SimulateStopWatch
    {
        public static void GetElapsedTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            CouponNumber.CheckCouponNumbers();
            stopwatch.Stop();
            Console.WriteLine("\n Elapsed time to get distinct coupons is  : " + stopwatch.ElapsedMilliseconds);
        }
    }
}
