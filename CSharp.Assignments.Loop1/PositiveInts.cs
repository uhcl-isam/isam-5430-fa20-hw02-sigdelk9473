using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class PositiveInts
    {
        /// <summary>
        /// First prompt for the value of n, then Write all the positive integers up to the integer n on separate lines. [Demonstration]
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter the value of n");
            int value = int.Parse(Console.ReadLine());
            int integer = 1;
            while (integer <= value)
            {
                Console.WriteLine(integer);
                integer++;
            }

            // write your codes here.
        }
    }
}
