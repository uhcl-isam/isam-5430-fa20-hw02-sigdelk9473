using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Develop a C# app that will determine whether any of several
    /// department-store customers has exceeded the credit limit on a charge
    /// account. For each customer, the following facts are available:
    ///    1) account number,
    ///    2) balance at the beginning of the month,
    ///    3) total of all items charged by the customer this month,
    ///    4) total of all credits applied to the customer’s account this month and,
    ///    5) allowed credit limit.
    /// The app should input all these facts as integers,
    /// calculate the new balance(= beginning balance + charges – credits),
    /// display the new balance and determine whether the new balance exceeds
    /// the customer’s credit limit.
    /// For those whose credit limit is exceeded, 
    /// the app should display the message "Credit limit exceeded" on a separate line. 
    /// Use sentinel-controlled iteration to obtain the data for each account
    /// (e.g. the iteration will terminate if the account number is a
    /// negative number).
    /// </summary>
    public class CreditLimitCalculator
    {
        public static void Main()
        {
            // read in account number
            // Enter your sentinel loop here
            while (true)
            {


                //int AccNum, BeginBal, TotalCharge, TotalCredit, CreditLimit;
                Console.WriteLine("Enter a account number");
                int AccNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a Beginning balance");
                int BeginBal = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter total Charge");
                int TotalCharge = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Total Credit");
                int TotalCredit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Credit Limit");
                int CreditLimit = int.Parse(Console.ReadLine());
                

                int newBalance = BeginBal + TotalCharge - TotalCredit;
                Console.WriteLine("The new balance is {0} ", newBalance);
                int RemainingBalance = CreditLimit - newBalance;


                if (CreditLimit < newBalance)
                {
                    Console.WriteLine("Credit Limit Exceeded");
                }
                if (AccNum < 0)
                {
                    break;

                   
                }
                Console.WriteLine("The remaining balance is {0} ", RemainingBalance);


            }
                

            
                
            

        }
    }
}
