using System;

namespace Week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloUser();
            Num();
        }public static void HelloUser()
        {
            Console.WriteLine("enter your name:");
            string username = Console.ReadLine();
            Console.WriteLine($"hello, {username}");
        }
        public static void Num()
        {
            Console.WriteLine("enter number 1");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2");
            int num2 = Int32.Parse(Console.ReadLine());
            int sum = num + num2;
            Console.WriteLine(sum);
        }

    }
}
