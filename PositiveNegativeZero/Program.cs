﻿/*
 * Positive Negative Zero
 * 1/9/2023
 * C#.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNegativeZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number >> ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("That is a positive number!");
            }
        }
    }
}
