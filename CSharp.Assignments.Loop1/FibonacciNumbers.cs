using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The Main app will prompt the user for the last number of the Fibonacci numbers.
    /// Then, the app will write a sequence of numbers in a Fibonacci sequence up to the last number.
    /// Fibonacci numbers are the numbers in the following integer sequence, called the Fibonacci sequence, 
    /// and characterized by the fact that every number after the first two is the sum of the two preceding ones.
    /// The first two numbers are 0 and 1 so the numbers will be 0 1 1 2 3 5 8 13 21 34 55 89...
    /// </summary>
    public class FibonacciNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter the last number of Fibonacci Sequence of numbers.");
            int end = int.Parse(Console.ReadLine());
            int fib = 0;
            int fibNum1 = 0;
            int fibNum2 = 1;
            int fibNum3;
            Console.Write("{0} {1} ", fibNum1, fibNum2);
            while ( fib < end)
            {
                fibNum3 = fibNum1 + fibNum2;
                Console.Write(fibNum3);
                Console.Write(" ");
                fibNum1 = fibNum2;
                fibNum2 = fibNum3;
                fib++;
            }
        }
    }
}
