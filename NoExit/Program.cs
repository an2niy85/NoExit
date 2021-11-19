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
            string conditionsExiting = "Выход";

            Console.WriteLine("Введите многострочный текст (Переход на новую строку - \"Enter\"), для выхода введите \"Выход\":");

            while (userInput != conditionsExiting)
            {
                userInput = Console.ReadLine();
            }
        }
    }
}
