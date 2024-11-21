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
    //это все для 4 задания 
    public enum LevelVorchanya
    {
        Low,
        Medium,
        High
    }
    public struct Ded
    {
        public string Name;
        public LevelVorchanya Level;
        public string[] Phrases;
        public int Siniki;

        public Ded(string name, LevelVorchanya Level1, string[] phrases)
        {
            Name = name;
            Level = Level1;
            Phrases = phrases;
            Siniki = 0;
        }
        public int Check(params string[] badWords)
        {
            foreach (var phrase in Phrases)
            {
                foreach (var badWord in badWords)
                {
                    if (phrase.Contains(badWord, StringComparison.OrdinalIgnoreCase))
                    {
                        Siniki++;
                    }
                }
            }
            return Siniki;
        }
    }
    internal class Program
    {
        // Метод для 1 задани
        static void ShowArray(params int[] array)
        {
            double c = 0;
            double d = 1;
            for (int i = 0; i < array.Length; i++)

            {
                c = c + array[i];
                d = d * array[i];
            }
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(c / array.Length);
        }
        //Метод для 1 задани
        static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }
            return numbers;
        }

        // Метод для 1 задания
        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        // Метод для 1 задания
        static void SwapElements(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        //метод для 3 задания
        static void PrintNumber(double n)
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine("  ###  ");
                    Console.WriteLine(" #   # ");
                    Console.WriteLine(" #   # ");
                    Console.WriteLine(" #   # ");
                    Console.WriteLine(" #   # ");
                    Console.WriteLine(" #   # ");
                    Console.WriteLine("  ###  ");
                    break;
                case 1:
                    Console.WriteLine(" ##");
                    Console.WriteLine("# #");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    Console.WriteLine("#####");
                    break;
                case 2:
                    Console.WriteLine(" ##");
                    Console.WriteLine("#   #");
                    Console.WriteLine("#      #");
                    Console.WriteLine("     #");
                    Console.WriteLine("   #");
                    Console.WriteLine("  #");
                    Console.WriteLine(" #");
                    Console.WriteLine("########");
                    break;
                case 3:
                    Console.WriteLine(" ##");
                    Console.WriteLine("#   #");
                    Console.WriteLine("#     #");
                    Console.WriteLine("     #");
                    Console.WriteLine("   #");
                    Console.WriteLine("     #");
                    Console.WriteLine(" #    #");
                    Console.WriteLine("  ###");
                    break;
                case 4:
                    Console.WriteLine("#    #");
                    Console.WriteLine("#    #");
                    Console.WriteLine("#    #");
                    Console.WriteLine("######");
                    Console.WriteLine("     #");
                    Console.WriteLine("     #");
                    Console.WriteLine("     #");
                    Console.WriteLine("     #");
                    break;
                case 5:
                    Console.WriteLine("######");
                    Console.WriteLine("#    ");
                    Console.WriteLine("#    ");
                    Console.WriteLine("######");
                    Console.WriteLine("      #");
                    Console.WriteLine("       #");
                    Console.WriteLine("      #");
                    Console.WriteLine("######");
                    break;
                case 6:
                    Console.WriteLine("   #####");
                    Console.WriteLine("  #    ");
                    Console.WriteLine(" #    ");
                    Console.WriteLine(" #####");
                    Console.WriteLine("#     #");
                    Console.WriteLine("#      #");
                    Console.WriteLine("#     #");
                    Console.WriteLine("#####");
                    break;
                case 7:
                    Console.WriteLine("#####");
                    Console.WriteLine("    #");
                    Console.WriteLine("    #");
                    Console.WriteLine(" ######");
                    Console.WriteLine("    #");
                    Console.WriteLine("    #");
                    Console.WriteLine("    #");
                    Console.WriteLine("    #");
                    break;
                case 8:
                    Console.WriteLine("  #### ");
                    Console.WriteLine(" #    #");
                    Console.WriteLine(" #    #");
                    Console.WriteLine("######");
                    Console.WriteLine("#      #");
                    Console.WriteLine("#      #");
                    Console.WriteLine("#      #");
                    Console.WriteLine(" ###### ");
                    break;
                case 9:
                    Console.WriteLine("  #### ");
                    Console.WriteLine(" #    #");
                    Console.WriteLine(" #    #");
                    Console.WriteLine("  #####");
                    Console.WriteLine("      #");
                    Console.WriteLine("      #");
                    Console.WriteLine("      #");
                    Console.WriteLine(" ###### ");
                    break;
            }
            // это для 2 задания
            static int Calculate(int[] numbers, ref int product, out double average)
            {
                int sum = 0;
                product = 1;
                foreach (int number in numbers)
                {
                    sum += number;
                    product *= number;
                }
                average = numbers.Length > 0 ? (double)sum / numbers.Length : 0;
                return sum;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("файл задание 1");
                int[] numbers = GenerateRandomArray(20, 1, 101);
                Console.WriteLine("Исходный массив:");
                PrintArray(numbers);
                Console.WriteLine("Введите первое число:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                int firstIndex = Array.IndexOf(numbers, firstNumber);
                int secondIndex = Array.IndexOf(numbers, secondNumber);
                if (firstIndex != -1 && secondIndex != -1)
                {
                    SwapElements(numbers, firstIndex, secondIndex);
                    Console.WriteLine("Массив после обмена местами:");
                    PrintArray(numbers);
                }
                else
                {
                    Console.WriteLine("Одно или оба числа не найдены в массиве.");
                }
                Console.WriteLine("файл задание 2");

                int[] numbers1 = { 2, 3, 4, 5 };
                int product = 1;
                double average;
                int sum = Calculate(numbers1, ref product, out average);
                Console.WriteLine($"Сумма: {sum}");
                Console.WriteLine($"Произведение: {product}");
                Console.WriteLine($"Среднее арифметическое: {average}");
                Console.WriteLine("файл задание 3");
                Console.WriteLine("Введите число");
                string A = Console.ReadLine();
                if (A.ToLower() == "exit" || A.ToLower() == "закрыть")
                {
                    Console.Clear();
                }
                else
                {
                    try
                    {
                        double n = Convert.ToDouble(A);
                        if (0 <= n && n <= 9)
                        {
                            PrintNumber(n);
                        }
                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Thread.Sleep(300);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Введите число!!");
                    }
                }
                Console.WriteLine("файл задание 4");
                Ded[] grandfathers = new Ded[5];
                grandfathers[0] = new Ded("Дед 1", LevelVorchanya.High, new string[] { "Гады!", "Как же мне надоело!", "Мрази!", "Ёкарный бабай!", "Негодяи!" });
                grandfathers[1] = new Ded("Дед 2", LevelVorchanya.High, new string[] { "Проститутки!", "Эх!", "Прохендеи!", "Негодник!" });
                grandfathers[2] = new Ded("Дед 3", LevelVorchanya.Medium, new string[] { "Что за безобразие!", "Гады!" });
                grandfathers[3] = new Ded("Дед 4", LevelVorchanya.Low, new string[] { "Достало!" });
                grandfathers[4] = new Ded("Дед 5", LevelVorchanya.Medium, new string[] { "Проститутки!", "Жопа!", "Оболдуй!" });
                string[] badWords = { "Проститутки!", "Гады!", "Жопа!" };
                foreach (var grandpa in grandfathers)
                {
                    int Siniki = grandpa.Check(badWords);
                    Console.WriteLine($"{grandpa.Name} получил {Siniki} синяков от бабки.");
                }

            }

        }
    }
}

