using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceQualification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Have you ever had a DUI? (true/false) ");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());
            Console.Write("How many speeding tickets do you have? ");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            bool isQualified = (age > 15) && !hasDUI && (speedingTickets <= 3);

            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);

            Console.ReadLine();
        }
    }
}
