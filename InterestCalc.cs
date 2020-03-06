using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.cs
{
    class InterestCalc
    {
        static void Main(string[] args)
        {

            decimal balance = 0;
            decimal finalBalance = 0;
            do
            {
                Console.WriteLine("Enter the beginning balance: ");
                balance = decimal.Parse(Console.ReadLine());


                Console.WriteLine("Enter the interest rate: ");
                decimal rate = decimal.Parse(Console.ReadLine());
                

                Console.WriteLine("Enter the number of year: ");
                int years = int.Parse(Console.ReadLine());

                finalBalance = (balance + ((balance * rate)* years));

                Console.WriteLine($"The amount you will have in {years} years is {finalBalance:c}.");

            } while (balance < finalBalance);

        }
       
    }
}
