using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void max(int c1, int c2)
        {
            if (c1 > c2)
            {
                Console.WriteLine($"({c1})");
            }
            else if (c1 < c2)
            {
                Console.WriteLine($"({c2})");
            }
            else
            {
                Console.WriteLine("Равны");
            }
        }
        public static void swap(ref int a1, ref int a2)
        {
            a1 = a1 + a2;
            a2 = a1 - a2;
            a1 = a1 - a2;
        }
        static bool Factorial1(ref int b)
        {
            int c = b;
            b = 1;
            for (int i = 1; i <= c; i++)
                try
                {
                    checked
                    {
                        b *= i;
                    }

                }
                catch 
                { 
                    return false; 
                }
            return true;
        }
        static int Factorial2(int n)
        {
            if (n == 0) return 1;
            return n * Factorial2(n - 1);
        }
        static int NOD(int x, int y)
        {
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }
            return y;
        }

        static int NOD(int x, int y, int c)
        {
            c = NOD(NOD(x, y), c);
            return c;
        }
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("Введите первое число");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int c2 = Convert.ToInt32(Console.ReadLine());
            max(c1, c2);

            Console.WriteLine("Упражнение 5.2");
            try
            {
                Console.WriteLine("Введите первое число");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int a2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}  {1}", a1, a2);

                swap(ref a1, ref a2);
                Console.WriteLine("{0}  {1}", a1, a2);
            }
            catch (FormatException)
            { 
                Console.WriteLine("Введите число!");
            }
            Console.WriteLine("Упражнение 5.3");
            Console.WriteLine("Введите число ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = Factorial1(ref n);
            Console.WriteLine(Convert.ToString(flag) + " " + Convert.ToString(n));
            Console.WriteLine("Упражнение 5.4");
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факториал числа {Factorial2(n)}");
            Console.WriteLine("Домашнее задание 5.1");
            Console.WriteLine("НОД 2 чисел");
            Console.WriteLine("Введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"НОД равен {NOD(x, y)}");
            Console.WriteLine("НОД 3 чисел");
            Console.WriteLine("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"НОД равен {NOD(x, y, c)}");
            Console.WriteLine("Домашнее задание 5.2 ");
            Console.WriteLine("Введите  число");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Fibonachi(n)}");
            Console.ReadKey();
        }
    }
}
