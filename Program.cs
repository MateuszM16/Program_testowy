using System;
using System.Collections.Concurrent;
using System.Dynamic;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            bool result = true;

            a = Read_a(ref result);
            Clear1(a);

            b = Read_b(ref result);
            Clear2(a, b);

            static void Clear1(double a)
            {
                Console.Clear();
                Console.WriteLine("Podaj liczbe (nr.1): " + a);
            }

            static void Clear2(double a, double b)
            {
                Clear1(a);
                Console.WriteLine("Podaj liczbe (nr.2): " + b);

                Console.WriteLine($"\n{a} + {b} = {a + b}");
                Console.WriteLine($"{a} - {b} = {a - b}");
                Console.WriteLine($"{a} * {b} = {a * b}");
                Console.WriteLine($"{a} : {b} = {a / b}");
            }
        }

        private static double Read_b(ref bool result)
        {
            double b;
            do
            {
                Error(result);

                Console.Write("Podaj liczbe (nr.2): ");
                result = double.TryParse(Console.ReadLine(), out b);
            } while (result == false);
            return b;
        }

        private static double Read_a(ref bool result)
        {
            double a;
            do
            {
                Error(result);

                Console.Write("Podaj liczbe (nr.1): ");
                result = double.TryParse(Console.ReadLine(), out a);
            } while (result == false);
            return a;
        }

        private static void Error(bool result)
        {
            if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zła liczba! Spróbuj ponownie\n");
                Console.ResetColor();
            }
        }
    }
}
