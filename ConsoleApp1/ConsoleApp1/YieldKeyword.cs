using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // Input : 10
    //Output: 0 2 4 6 8
    // Below section in main class
    //var numbers = YieldKeyword.CalculateRunningTotal();
    //foreach(var x in numbers)
    //{
    //    Console.WriteLine(x);
    //}


    // What is the use of Yield keyword in c#?
    //Defination: The yield keyword will act as an interator blocker and generate or return values.
    internal class YieldKeyword
    {
       public static IEnumerable<int> GetEvenNumbers(int num)
        {
            //var numbers = new List<int>();
            for (int i = 0; i < num; i += 2)
            {
                // numbers.Add(i);
                yield return i;
            }
            // return numbers;
        }

        //calculate running total
        // 1        1
        // 2        3
        // 3        6
        // 4        10
        // 5        15


        static List<int> myList = new List<int> { 1, 2, 3, 4, 5 };

       public static IEnumerable<int> CalculateRunningTotal()
        {
            int runningTotal = 0;
            foreach (int i in myList)
            {
                runningTotal += i;
                yield return runningTotal;
            }
        }
    }
}
