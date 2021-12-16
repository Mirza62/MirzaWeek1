using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class PlusMinus
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Friends!Write the length of integer array");
            int noflN = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Could you please provide the array value using spaces");
            List<int> costarra = Console.ReadLine().TrimEnd().Split(' ').ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            PlusMinus.plusMinus(costarra);
        }


        public static void plusMinus(List<int> arrayofint)
        {
            int totalnumberofelements = arrayofint.Count();
            int positivenos =0 ;
            int negativenos = 0;
            int neutralnumber = 0;

            foreach (var integer in arrayofint)
            {
                if (integer < 0)
                {
                    negativenos++;
                }
                else if (integer > 0)
                {
                    positivenos++;
                }
                else if (integer == 0)
                {
                    neutralnumber++;
                }
            }

            decimal firstOutput = (decimal)positivenos / (decimal)totalnumberofelements;
            decimal secondOutput = (decimal)negativenos / (decimal)totalnumberofelements;
            decimal thirdOutput = (decimal)neutralnumber / (decimal)totalnumberofelements;
            firstOutput = Math.Round(firstOutput, 6);
            secondOutput = Math.Round(secondOutput, 6);
            thirdOutput = Math.Round(thirdOutput, 6);
            Console.WriteLine(firstOutput);
            Console.WriteLine(secondOutput);
            Console.WriteLine(thirdOutput);
        }


    }
}
