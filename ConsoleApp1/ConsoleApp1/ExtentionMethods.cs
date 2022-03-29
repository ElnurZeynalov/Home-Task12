using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal static class ExtentionMethods
    {
        public static bool Odd(this int value)
        {
            if (value % 2 != 0)
                return true;
            return false;
        }
        public static bool Even(this int value)
        {
            if (value % 2 == 0)
                return true;
            return false;
        }
        public static bool IsContainsDigit(this string str)
        {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                        return true;
                }
            return false;
        }
        public static void ToCapitalize(this string str)
        {
                str = str.ToLower();
                Console.WriteLine(char.ToUpper(str[0]) + str.Substring(1));
            
        }
        public static int[] GetValueIndexes(this string str , char chr)
        {
            int[] arr = new int[0];
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == chr)
                    {
                        Array.Resize(ref arr, arr.Length+1);
                        arr[arr.Length-1] = i;
                    }
                }
                return arr;                
        }
    }
}
