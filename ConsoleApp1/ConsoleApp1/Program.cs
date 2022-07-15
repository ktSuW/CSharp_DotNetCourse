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
            //string s = "100";
            //string s1 = null;
            //Console.WriteLine(Convert.ToInt32(s));
            //Console.WriteLine(Convert.ToInt64(s));
            //Console.WriteLine(Convert.ToInt16(s));
            //Console.WriteLine(int.Parse(s));
            //Console.WriteLine(Convert.ToInt32(s1));
            //Console.WriteLine(int.Parse(s1));
            //Console.ReadKey();

            //int a = 10;
            //char c = 'a';
            //float f = 23.40f;
            //double d = 20.34;
            //long l = 121323423423;
            //bool b = true;
            //string s = "ramen"; // reference type => memory is executed during runtime

            //Console.WriteLine(a + " \t" + sizeof(int));
            //Console.WriteLine(c + " \t" + sizeof(char));
            //Console.WriteLine(f + " \t" + sizeof(float));
            //Console.WriteLine(d + " \t" + sizeof(double));
            //Console.WriteLine(l + " \t" + sizeof(long));
            //Console.WriteLine(b + " \t" + sizeof(bool));

            // Collection types 
            /*
             * string
             * list
             * sortedlist
             * linkedlist 
             * array 
             * arraylist 
             * hashtable 
             * dictionary 
             * stack
             * queue 
             * 
             * Operators 
             * ===================
             * 
             */
            // Increment 
            //int a = 1;
            //int b = a++;
            //Console.WriteLine(b);
            //=======================
            /*
             * conditional statement
             * ====================
             *  if
             *  if else
             *  nested if
             *  switch 
             *  
             *  
             * iterative statement
             * =================
             * for loop
             * while loop
             * foreach loop
             * 
             * 
             * transfer statement 
             * =================
             * break
             * continue
             * goto
             */
            //int a = 100;
            //if(a == 100)
            //{
            //    Console.WriteLine(a + $" is {a} and you are correct");
            //}
            Console.WriteLine("Enter your number: ");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1: Console.WriteLine("It is 1."); break;
                case 2: Console.WriteLine("It is 2."); break ;
            }
            Console.Read();
        }
    }
}
