﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDegitOfNumber
{
    class LastDegitOfNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetLastDegitAsWord(number));
        }

        static string GetLastDegitAsWord(int number)
        {
            switch (number % 10)
            {
                case 1:
                    return "One";
                    break;
                case 2:
                    return "Two";
                    break;
                case 3:
                    return "Three";
                    break;
                case 4:
                    return "Four";
                    break;
                case 5:
                    return "Five";
                    break;
                case 6:
                    return "Six";
                    break;
                case 7:
                    return "Seven";
                    break;
                case 8:
                    return "Eight";
                    break;
                case 9:
                    return "Nine";
                    break;
                case 0:
                    return "Zero";
                    break;
            }
            return "Error";
        }
    }
}
