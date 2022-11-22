using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лаба_2
{
    class Program
    {
        static void DoBlock_1()
        {
            Console.WriteLine("Enter the number of numbers in the sequence");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            int i = 0;
            int count = 0;
            
            while (count < n)
            {
                count++;
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 != 0)
                {
                    i++;
                }
            }
            Console.WriteLine($"Number of odd elements = {i}");
        }
        static void DoBlock_1_1()
        {
            Console.WriteLine("Enter the number of numbers in the sequence");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            int i;
            int count = 0;
            for (i = 0; i < n; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 != 0)
                {
                    count++; ;
                }
            }
            Console.WriteLine($"Number of odd elements = {count}");
        }
        static void DoBlock_1_2()
        {
            Console.WriteLine("Enter the number of numbers in the sequence");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            int i = 0;
            int count = 0;
            do
            {
                count++;
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 != 0)
                {
                    i++;
                }
            } while (count < n);

            Console.WriteLine($"Number of odd elements = {i}");
        }
        static void DoBlock_2()
        {
            int num = 1;
            int i = 0;
            int count = 0;
            int sum = 0;
            Console.WriteLine("Enter a sequance of numbers");
            while (num != 0)
            {
                count++;
                num = Convert.ToInt32(Console.ReadLine());
                if (count % 2 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }
        static void DoBlock_2_1()
        {
            int num = 1;
            int sum = 0;
            Console.WriteLine("Enter a sequance of numbers");
            for (int i = 0; num != 0; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (i % 2 != 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }
        static void DoBlock_2_2()
        {
            int num = 1;
            int sum = 0;
            int count = 0;
            Console.WriteLine("Enter a sequance of numbers");
            do
            {
                count++;
                num = Convert.ToInt32(Console.ReadLine());
                if (count % 2 == 0)
                {
                    sum += num;
                }
            } while (num != 0);
            Console.WriteLine($"Sum = {sum}");
        }
        static void DoBlock_3()
        {
            Console.WriteLine("Assign a value for x");
            double x = Convert.ToDouble(Console.ReadLine());
            double P = 0;
            double num = 1;
            double num2 = 2;
            double prev = 2;
            double next = 0;
            double prev2 = 2;
            double next2 = 0;
            double a = 1;
            double b = 1;
            double mul = 1;
            double mul2 = 1;
            while (num <= 63 && num2 <= 64)
            {

                a = x - num;// (X-2)(x-3)(x-7)...(x-63)
                num += prev;//(2,3,7...63)
                next = prev * 2;
                prev = next;
                mul *= a;
                a = mul;

                b = x - num2;// (X-2)(x-4)(x-8)...(x-64)
                num2 += prev2;//(2,3,7...64)
                next2 = prev2 * 2;
                prev2 = next2;
                mul2 *= b;
                b = mul2;
            }
            if (b == 0)
            {
                Console.WriteLine("Try another number");
            }
            else
            {
                P = a / b;
                Console.WriteLine($"P = {P}");
            }
        }
        static void DoBlock_3_1()
        {
            Console.WriteLine("Assign a value for x");
            double x = Convert.ToDouble(Console.ReadLine());
            double P = 0;
            double num = 1;
            double num2 = 2;
            double prev = 2;
            double next = 0;
            double prev2 = 2;
            double next2 = 0;
            double a = 1;
            double b = 1;
            double mul = 1;
            double mul2 = 1;
            for (int i = 0; num <= 63 && num2 <= 64; i++)
            {
                a = x - num;// (X-2)(x-3)(x-7)...(x-63)
                num += prev;//(2,3,7...63)
                next = prev * 2;
                prev = next;
                mul *= a;
                a = mul;

                b = x - num2;// (X-2)(x-4)(x-8)...(x-64)
                num2 += prev2;//(2,3,7...64)
                next2 = prev2 * 2;
                prev2 = next2;
                mul2 *= b;
                b = mul2;
            }
            if (b == 0)
            {
                Console.WriteLine("Try another number");
            }
            else
            {
                P = a / b;
                Console.WriteLine($"P = {P}");
            }
        }
        static void DoBlock_3_2()
        {
            Console.WriteLine("Assign a value for x");
            double x = Convert.ToDouble(Console.ReadLine());
            double P = 0;
            double num = 1;
            double num2 = 2;
            double prev = 2;
            double next = 0;
            double prev2 = 2;
            double next2 = 0;
            double a = 1;
            double b = 1;
            double mul = 1;
            double mul2 = 1;
            do
            {
                a = x - num;// (X-2)(x-3)(x-7)...(x-63)
                num += prev;//(2,3,7...63)
                next = prev * 2;
                prev = next;
                mul *= a;
                a = mul;

                b = x - num2;// (X-2)(x-4)(x-8)...(x-64)
                num2 += prev2;//(2,3,7...64)
                next2 = prev2 * 2;
                prev2 = next2;
                mul2 *= b;
                b = mul2;
            } while (num <= 63 && num2 <= 64);
            if (b == 0)
            {
                Console.WriteLine("Try another number");
            }
            else
            {
                P = a / b;
                Console.WriteLine($"P = {P}");
            }
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Для виконання блоку 1 (варiант ...) введiть 1");
                Console.WriteLine("Для виконання блоку 1_1 (варiант ...) введiть 11");
                Console.WriteLine("Для виконання блоку 1_2 (варiант ...) введiть 12");
                Console.WriteLine("Для виконання блоку 2 (варiант ...) введiть 2");
                Console.WriteLine("Для виконання блоку 2_1 (варiант ...) введiть 21");
                Console.WriteLine("Для виконання блоку 2_2 (варiант ...) введiть 22");
                Console.WriteLine("Для виконання блоку 3 (варiант ...) введiть 3");
                Console.WriteLine("Для виконання блоку 3_1 (варiант ...) введiть 31");
                Console.WriteLine("Для виконання блоку 3_2 (варiант ...) введiть 32");
                Console.WriteLine("Для виходу з програми введiть 0");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Виконую блок 1");
                        DoBlock_1();
                        break;
                    case 11:
                        Console.WriteLine("Виконую блок 11");
                        DoBlock_1_1();
                        break;
                    case 12:
                        Console.WriteLine("Виконую блок 12");
                        DoBlock_1_2();
                        break;
                    case 2:
                        Console.WriteLine("Виконую блок 2");
                        DoBlock_2();
                        break;
                    case 21:
                        Console.WriteLine("Виконую блок 21");
                        DoBlock_2_1();
                        break;
                    case 22:
                        Console.WriteLine("Виконую блок 22");
                        DoBlock_2_2();
                        break;
                    case 3:
                        Console.WriteLine("Виконую блок 3");
                        DoBlock_3();
                        break;
                    case 31:
                        Console.WriteLine("Виконую блок 31");
                        DoBlock_3_1();
                        break;
                    case 32:
                        Console.WriteLine("Виконую блок 32");
                        DoBlock_3_2();
                        break;
                    case 0:
                        Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 3, 0.", choice);
                        break;
                }
            } while (choice != 0);
        }
    }
}//проверка гита11