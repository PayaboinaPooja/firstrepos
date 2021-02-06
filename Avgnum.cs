using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Avgnum
    {
        static void Main(string[] args)
        {
            int num = 234;
            int sum = 0;
            int count = 0;
            int avg = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                count++;
                num = num / 10;
            }
            avg = sum / count;
            Console.WriteLine(avg);
        }
    }
}
