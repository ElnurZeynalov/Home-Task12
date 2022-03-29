using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(value.Odd());

            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(value2.Even());

            string str = Console.ReadLine();
            Console.WriteLine(str.IsContainsDigit());

            string str2 = Console.ReadLine();
            str2.ToCapitalize();

            string str3 = Console.ReadLine();
            char chr = Convert.ToChar(Console.ReadLine());
            foreach (var item in str3.GetValueIndexes(chr))
            {
                Console.WriteLine(item);
            }

        }
    }
}
