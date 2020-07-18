using System;

namespace GroupTotals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Group();
            Console.WriteLine(a.GroupTotals(new string[] { "X:-1", "Y:1", "X:-4", "B:3", "X:5" }));
            Console.ReadKey();
        }
    }
}
