﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            Console.Error.WriteLine("Enter the starting number");
            int num1 = int.Parse(Console.ReadLine());
            // Codes to enter start
            Console.Error.WriteLine("Enter the ending number");
            int num2 = int.Parse(Console.ReadLine());
            // Codes to enter end.

            for (int k = num1; k <= num2; k++)
            
            {
                if ((k % 2) != 0)
                {
                   Console.WriteLine(k);
                    k++;
                }
                
                //Console.WriteLine(k);
                //k++;
            }
        }
    }
}
