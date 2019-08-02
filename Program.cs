using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excese_Bank__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping, the first number is: " + num1);
            Console.WriteLine("the second number is: " + num2);
            Console.ReadLine();
        }
    }
}
