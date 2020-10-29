using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment
{

    class Program
    {
        static void Main(string[] args)
        {
            /*User enters the amomunt to be invested*/
            decimal principal;
            string input;
            const int LOW = 0;

            Console.Write("Enter the amount you would like to invest: ");
            input = Console.ReadLine();
            principal = Convert.ToInt32(input);

            while (principal == LOW)
            {
                Console.WriteLine("invalid number. A number higher than zero is required.");
                Console.Write("Please enter your investment amount: ");
                input = Console.ReadLine();
                principal = Convert.ToInt32(input);

            }
            Console.WriteLine();


            /*Number of years for the investment*/
            double yearsInvested;
            string input1;
            const int LOW1 = 0;

            Console.Write("Enter the number of years you would like to invest this amount: ");
            input1 = Console.ReadLine();
            yearsInvested = Convert.ToInt32(input1);

            while (yearsInvested == LOW1)
            {
                Console.WriteLine("invalid number. A number higher than zero is required.");
                Console.Write("Please enter the number of years you would like to invest the monatary amount above: ");
                input1 = Console.ReadLine();
                yearsInvested = Convert.ToInt32(input1);

            }
            Console.WriteLine();


            /*interest calculation*/
            decimal amount; //total amount of compound interest
            double rate = 0.08; //interest rate
            int year; //used to progress calculation & compare user input

            Console.WriteLine("Year{0,30}", "Total amount with interest"); //display headers

            for (year = 1; year <= yearsInvested; year++)
            {
                amount = principal * ((decimal)Math.Pow(1.0 + rate, year)); //interest calculation/year

                Console.WriteLine("{0,4}{1,20:C}", year, amount); //display the year and amount


            }

            Console.ReadLine();
            
        }
        
        

        








    }



}



