using System;

namespace CInemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            static void testdef()
            {
                Console.WriteLine("teeesssttttt");
            }

            static void part2()
            {
                Console.WriteLine("neeeeiiiiiinnnnnn");
            }

            int inp = Convert.ToInt32(Console.ReadLine());
            if (inp > 0)
                testdef();
            else
                part2();
        }
    }
}
