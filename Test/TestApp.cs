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
            MyCode.AutoGenerate();

            var mt = typeof(Math<>);
            foreach (var t in MyType.NumberSet)
            {
                Console.WriteLine(t);
                try
                {
                    var fs = mt.MakeGenericType(t).GetFields(MyReflection.PublicStatic);
                    foreach (var f in fs)
                    {
                        var o = f.GetValue(null);
                        if (o is Delegate d) continue;
                        Console.WriteLine($"\t{f.Name} = {o}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            Console.ReadKey();
        }
    }
}
