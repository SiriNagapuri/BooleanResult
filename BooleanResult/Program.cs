using System;

namespace BooleanResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for y");
            int y = Convert.ToInt32(Console.ReadLine());
            bool result = x < y;

            Console.WriteLine("x is less than y is "+result);

        }
    }
}
