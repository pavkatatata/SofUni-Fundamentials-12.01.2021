﻿using System;
using System.Linq;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {

            string vowels = Console.ReadLine();

            VowelsCount(vowels);



        }

        private static void VowelsCount(string vowels)
        {
            int counter = 0;

            vowels = vowels.ToLower();

            char[] onlyLetters = new char[vowels.Length];

            for (int i = 0; i < vowels.Length; i++)
            {

                if (vowels[i] == 'a' || vowels[i] == 'e' || vowels[i] == 'i' ||
                    vowels[i] == 'o' || vowels[i] == 'u')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

        }
    }
}