﻿using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


            Console.WriteLine(SmallestNumbers(num1, num2, num3));




        }

        private static int SmallestNumbers(int num1, int num2, int num3)
        {

            int min = Math.Min(Math.Min(num1, num2), num3);

            return min;


        }
    }
}