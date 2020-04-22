using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables declared
            int num1 = 0;
            int num2 = 0;

            //Title
            Console.WriteLine("         Console Calculator in C#         \r");
            Console.WriteLine("------------------------------------------\n");

            //user types first number
            Console.WriteLine("Type a number, and then press Enter:");
            num1 = Convert.ToInt32(Console.ReadLine());

            // user types second number
            Console.WriteLine("Type another number, then press Enter:");
            num2 = Convert.ToInt32(Console.ReadLine());

            //ask user to choose what they want to do
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t1 - Add");
            Console.WriteLine("\t2 - Subtract");
            Console.WriteLine("\t3 - Multiply");
            Console.WriteLine("\t4 - Divide");
            Console.WriteLine("Your Option?");

            //Switch statement to do the math
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Your result: " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine("Your result: " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine("Your result: " + (num1 * num2));
                    break;
                case "4":
                    Console.WriteLine("Your result: " + (num1 / num2));
                    break;
            }

            //Wait for user to respond to close
            Console.Write("Press any key to close Calculator app. . .");
            Console.ReadKey();
        }
    }
}
