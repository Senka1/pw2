using System;

namespace PW2
{
    class Number
    {
        private int n = 0;

        public bool SetNumber(int number)
        {
            if (number == n + 1)
            {
                n = number;
                return true;
            }
            else
            {
                n = 0;
                return false;
            }
        }

        public int GetExpectedNumber()
        {
            return n + 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            int expectedNumber = 1;

            while (true)
            {
                Console.Write($"Enter the number {expectedNumber}: ");
                int inputNumber = int.Parse(Console.ReadLine());

                if (number.SetNumber(inputNumber))
                {
                    expectedNumber++;
                }
                else
                {
                    expectedNumber = 1;
                    Console.WriteLine("Wrong number entered. Starting over.");
                }

                Console.WriteLine($"Expected number: {number.GetExpectedNumber()}");
            }
        }
    }
}
