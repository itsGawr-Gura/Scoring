using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring
{
    internal class Program
    {
        //EX 2
        static string[] SortByLength(string[] input)
        {
            Array.Sort(input, (x, y) => x.Length.CompareTo(y.Length));
            return input;
        }
        //EX 5
        public static int? FindClosestToZero(int[] numbers)
        {
            if (numbers.Contains(0))
            {
                return 0;
            }

            int? closest = null;
            foreach (int number in numbers)
            {
                if (closest == null || Math.Abs(number) < Math.Abs(closest.Value) || (Math.Abs(number) == Math.Abs(closest.Value) && number > 0))
                {
                    closest = number;
                }
            }

            return closest;
        }
        static void Main(string[] args)
        {
            //EX 1 Diamond
            Console.WriteLine("EX 1 Diamond");
            Console.WriteLine(Diamond.Make(5));
            
            //EX 2 Sort by lenght
            Console.WriteLine("EX 2 Sort by lenght");
            string[] input = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            string[] sortedArray = SortByLength(input);

            foreach (var str in sortedArray)
            {
                Console.WriteLine(str);
            }
            //EX 5 Closest to zero
            Console.WriteLine("EX 5 Closest to zero");
            int[] nums1 = new int[] { 2, 4, -1, -3 };
            Console.WriteLine(FindClosestToZero(nums1));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
