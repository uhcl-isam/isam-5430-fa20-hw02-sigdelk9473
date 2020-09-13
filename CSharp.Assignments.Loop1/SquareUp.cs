﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    public class SquareUp
    {
        /// <summary>
        /// Create an app that inputs one number, n >= 0. The app will print out n*n integers with the following pattern; for n=3, the app will print out 0, 0, 1,    0, 2, 1,    3, 2, 1 on separate lines (spaces added to show the 3 groups).
        /// </summary>
        public static void Main()
        {
            // Write your codes here
            Console.WriteLine("Enter one number");
            int number = int.Parse(Console.ReadLine());
            for (int row = 1; row <= number; row++)

            {
                int c = 0;
                for (int col = 1; col <= number; col++)
                {

                    if (col > number - row)
                    {
                        Console.Write(row - c);
                        Console.Write(", ");
                          
                        c++;
                    }
                    else
                    {
                        Console.Write("0");
                        Console.Write(", ");
                    }
                }

                Console.WriteLine("\n");
            }
            

            
        }
    }
}
