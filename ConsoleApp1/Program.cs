using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

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
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Try another number");
            }
            else
            {
                P = a / b;
                Console.WriteLine(P);
            }

            
           
        }
    }
}
