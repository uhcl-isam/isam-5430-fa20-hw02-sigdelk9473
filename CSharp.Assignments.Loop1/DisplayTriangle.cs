using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Write an app reads two inputs: a character that indicates which pattern to choose ('a' = lower left triangle, 'b' = upper left triangle, 'c' = upper right triangle, 'd' = lower right triangle) and an integer that indicates the number of lines to display. The app will then display the following patterns separately, one below the other. Use for loops to generate patterns. All asterisks (*) should be displayed by a signle statement of the form Console.Write('*'); which causes the asterisks to display side by side. A statement of the form Console.WriteLine(); can be used to move to the next line. A statement of the form COnsole.Write(' '); can be used to display a space for the last two patterns., There should be no other output statements in the app. [Hint: the last two patterns require that each line begin with an appropriate number of blank spaces.
    /// </summary>
    /// <example>
    ///    (a)          (b)         (c)          (d)
    /// *           **********  **********           *
    /// **          *********    *********          **
    /// ***         ********      ********         ***
    /// ****        *******        *******        ****
    /// *****       ******          ******       *****
    /// ******      *****            *****      ******
    /// *******     ****              ****     *******
    /// ********    ***                ***    ********
    /// *********   **                  **   *********
    /// **********  *                    *  **********
    /// </example>
    public class DisplayTriangle
    {
        public static void Main()
        {
            Console.Error.WriteLine("Type 'a' = lower left triangle; 'b' = upper left triangle; 'c' = upper right triangle; 'd' = lower right triangle.");
            char t = Convert.ToChar(Console.ReadLine());
            Console.Error.WriteLine("Enter the number of lines.");
            int n = Convert.ToInt32(Console.ReadLine());

            // Write your codes here.

            Console.ReadLine();
            //triangle == a
            if (t == 'a')
            {
                int row = 0;
                while (row < n)
                {
                    int col = 0;
                    while (col <= row)
                    {
                        Console.Write("*");
                        col++;
                    }
                    Console.WriteLine();
                    row++;
                }
            }
            //Triangle == b
            if (t == 'b')
            {
                int row1 = n;
                while (0 < row1)
                {
                    int col1 = 0;
                    while (col1 < row1)
                    {
                        Console.Write("*");
                        col1++;
                    }
                    Console.WriteLine();
                    row1--;
                }
            }
            //triangle == c;
            if (t == 'c')
            {
                for (int row2 = 0; row2 < n; row2++)
                {
                    for (int col2 = 0; col2 < n; col2++)
                    {
                        if (row2 > col2)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
            if (t == 'd')
            {
                for (int row3 = n; 0 < row3; row3--)
                {
                    for (int col3 = 0; col3 < n; col3++)
                    {
                        if (row3 > col3)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }

                    }
                    Console.WriteLine();
                }
            }






        }
    }
}

