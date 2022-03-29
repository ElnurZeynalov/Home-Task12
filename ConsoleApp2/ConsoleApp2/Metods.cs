using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal static class Metods
    {
        public static bool GroupNoChecker (this string str)
        {
            if (char.IsUpper(str[0]) && char.IsDigit(str[1]) && char.IsDigit(str[2]) && char.IsDigit(str[3]))
                return true;
            return false;
        }
        public static bool FullNameChecker (this string str)
        {
            string[] Arr = str.Split(' ');
            if (Arr.Length == 2)
            {
               if (char.IsUpper(Arr[0][0]) && char.IsUpper(Arr[1][0]))
                {
                    int name = 0;
                    for (int i = 1; i < Arr[0].Length; i++)
                    {
                        if (char.IsLower(Arr[0][i]))
                            name++;
                    }
                    int lastname=0;
                    for (int i = 1; i < Arr[1].Length; i++)
                    {
                        if (char.IsLower(Arr[1][i]))
                            lastname++;
                    }
                    if (name == Arr[0].Length-1 && lastname == Arr[1].Length-1)
                        return true;
                }
                    
            }
            return false;
        }
    }
}
