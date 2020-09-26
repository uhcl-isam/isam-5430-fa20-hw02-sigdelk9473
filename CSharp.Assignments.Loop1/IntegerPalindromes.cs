using System;
using System.ComponentModel.DataAnnotations;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            // enter sentinel inputs
            // then check the palindrome only once.
            int num, temp,revNum = 0, rem;
            while (true)
            {

                Console.WriteLine("Enter nine digit number");
                num = int.Parse(Console.ReadLine());
                //num = 123454321
                temp = num;
                if (num > 99999999 && num < 1000000000)
                {
                    break;
                }

            }


            while (num > 0)
            {



                rem = num % 10;
                revNum = (revNum * 10) + rem;
                num = num / 10;





            }
            if (temp == revNum)
            {
                Console.WriteLine("The number is Palindrome");
            }
            else
            {
                Console.WriteLine("The number is not Palindrome");
            }










        }

    }
}
