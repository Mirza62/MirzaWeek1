using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMaxSum
{
    class MiniMaxSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Friends,Please enter the value of integer array, Thank you");
            List<int> costarr = Console.ReadLine().Trim().Split(' ').ToList().Select(a => Convert.ToInt32(a)).ToList();
            MiniMaxSum.MinimumMaximum(costarr);
        }

        public static void MinimumMaximum(List<int> arr)
        {
                List<long> arrLong = arr.Select(i => (long)i).ToList();
                Console.WriteLine(((arrLong.Sum()) - arrLong.Max()) + " " + ((arrLong.Sum()) - arrLong.Min()));
        }
    }
}
/* My Solution
//1
foreach (var insidenumber in arr)
{//5
    if (number != insidenumber)
    {
        int a = number + insidenumber;
        calculate.Add(a);
    }
}
int value = calculate.Sum();
calculate.Clear();
Result.Add(value);
}

int minimumValue = Result.Min();
int maximumValue = Result.Max();
int mininumvalueinarray = arr.Min();
int maximumvalueinarray = arr.Max();
int result1 = minimumValue - maximumvalueinarray;
int result2 = maximumValue - mininumvalueinarray;
Console.WriteLine("the minimum value" + result1 + " " + "the maximum value" + result2);
*/

/*Next Best 
 
             //var max = Int64.MinValue;
            //var min = Int64.MaxValue;
            //int sum = 0;
            //foreach (var number in arr)
            //{
            //    sum += number;
            //    max = Math.Max(number, max);
            //    min = Math.Min(number, min);
            //}
            //Console.WriteLine((sum - max)+ " " + (sum-min));
 
 
 */



