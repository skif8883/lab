using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a * b;
            d = c * c;
            Console.WriteLine(d);

        }
    }
}
