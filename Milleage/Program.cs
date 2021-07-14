using System;

namespace Milleage
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMilleage;
            string inputGas;
            double milleage;
            double gas;
            double mpg;

            Console.WriteLine("Enter the number of miles you drove:");
            inputMilleage = Console.ReadLine();
            milleage = double.Parse(inputMilleage);

            Console.WriteLine("Enter the number of gas you consumed:");
            inputGas = Console.ReadLine();
            gas = double.Parse(inputGas);

            mpg = milleage / gas;
            Console.WriteLine("You've driven:" + mpg);
            Console.ReadLine();
        }
    }
}
