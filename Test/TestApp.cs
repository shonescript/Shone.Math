using System;
using Shone;

namespace Test
{
    public class TestApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math<float>.PI);
            Console.WriteLine(Math<float>.Pow(5, 3));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
