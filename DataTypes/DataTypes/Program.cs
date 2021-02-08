using System;
using System.ComponentModel.DataAnnotations;

namespace Ex_Arr_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DataTypee(input);

           
        }

        private static void DataTypee(string input)
        {
            if (input == "int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"{number * 2}");
            }

            else if (input == "real")
            {
                double symbol = double.Parse(Console.ReadLine());
                Console.WriteLine($"{symbol * 1.5:f2}");
            }

            else if (input == "string")
            {
                string symbol = Console.ReadLine();
                Console.WriteLine("$" + symbol + "$");
            }
        }
    }
}