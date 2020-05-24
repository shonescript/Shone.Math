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
            TestAllTypes();
            //Console.WriteLine(Math<bool>.PI);
            Console.ReadKey();
        }

        static void TestAllTypes()
        {
            var mt = typeof(Math<>);
            foreach (var t in MyType.WholeNumSet)
            {
                Console.WriteLine(t);
                var fs = mt.MakeGenericType(t).GetFields(MyReflection.PublicStatic);
                foreach (var f in fs)
                {
                    try
                    {
                        var o = f.GetValue(null);
                        if (o is Delegate d) continue;
                        Console.WriteLine($"\t{f.Name} = {(o == null ? "...................." : o.ToString())}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\t{f.Name} = !!!!!!!!!!!!!!!!!!{ex.Message}");
                    }
                }
            }
        }
    }
}
