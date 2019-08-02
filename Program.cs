using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1
{
    //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(newString("asdfg"));
            Console.WriteLine(newString("a"));
            Console.WriteLine(newString("xy"));
            Console.ReadLine();
        }
        public static string newString (string s)
        {
            return s.Length > 1
                ? s.Substring(s.Length - 1) + s.Substring(1, s.Length - 2) + s.Substring(0, 1) : s;
        }
    }
}
