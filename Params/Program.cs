using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsSum(5, 5);
            DisplayString("some random string");
        }
        public static void ParamsSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        public static void DisplayString(string Stringfunc)
        {
            Console.WriteLine(Stringfunc);
        }
        

    }
}
