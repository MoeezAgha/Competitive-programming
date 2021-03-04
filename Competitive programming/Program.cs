using System;
using System.Collections.Generic;

namespace Competitive_programming
{
    /// <summary>
    /// There are many different solution routes,
    /// each of which involves a different technique.This handout details the problem and gives
    /// a few different solution routes.
    /// 
    /// Problem Statement:
    /// 
    /// You are given an array of n integers and a number k.Determine whether there is a pair
    /// of elements in the array that sums to exactly k.For example, given the array[1, 3, 7] and
    /// k = 8, the answer is “yes,” but given k = 6 the answer is “no.”
    ///</summary>


    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 7 };
            var result = TwoNumberSum(array, 8);
            Console.WriteLine($"{result[0]},{result[1]}");
        }
        public static int[] TwoNumberSum(int[] array, int target)
        {
            HashSet<int> numbers = new();
            foreach (var item_x in array)
            {
                int potnialMatch_y = target - item_x;
                if (numbers.Contains(potnialMatch_y))
                {
                    return new int[] { potnialMatch_y, item_x };
                }
                else
                {
                    numbers.Add(item_x);
                }
            }
            return Array.Empty<int>();

        }
    }

   
}
