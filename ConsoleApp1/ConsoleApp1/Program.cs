//predefined namespaces 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a and b , c: ");
            //int a, b, c;
            //string d = "100";
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The result is {a+b + c}");
            string s = "100";
            string s1 = null;
            Console.WriteLine(Convert.ToInt32(s));
            Console.WriteLine(Convert.ToInt64(s));
            Console.WriteLine(Convert.ToInt16(s));
            Console.WriteLine(int.Parse(s));
            Console.WriteLine(Convert.ToInt32(s1));
            Console.WriteLine(int.Parse(s1));
            Console.ReadKey();
        }
    }
}
