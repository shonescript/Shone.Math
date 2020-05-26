using System;
using System.Text;
using System.IO;
using System.Reflection;
using Shone;

namespace Test
{
    public class TestApp
    {
        static void Main(string[] args)
        {
            //var a = Real.PI*3;
            //var b = 5.ToReal().Pow(3);
            //var c = new double[] { 5, 6, 7 }.ToReal().Pow(3);

            //MyCode.AutoGenerate();
            MyType.TestAllTypes();
            Console.ReadKey();
        }
    }
}
