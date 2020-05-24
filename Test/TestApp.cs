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
            //MyCode.AutoGenerate();
            MyType.TestAllTypes();
            Console.ReadKey();
        }
    }
}
