using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoExit
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string conditionsExiting = "exit";

            while (userInput != conditionsExiting)
            {
                Console.WriteLine("Введите слово:");
                userInput = Console.ReadLine();
            }
        }
    }
}
