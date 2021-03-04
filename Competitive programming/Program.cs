using System;
using System.Collections.Generic;

namespace Competitive_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 5, 1, 23 };
            var result = TwoNumberSum(array, 10);
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
