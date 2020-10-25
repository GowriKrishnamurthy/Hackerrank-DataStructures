using System;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the # of strings.");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the strings.");            
            for (int i = 0; i < num; i++)
            {
                string s = Console.ReadLine();
                string result = BalancedBrackets.IsBalanced(s);
                Console.WriteLine(result);
            }
            
        }
    }
}
