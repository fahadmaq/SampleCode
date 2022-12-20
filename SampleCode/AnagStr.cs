using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class AnagStr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter Second string");
            string secondString = Console.ReadLine();

            if (firstString.Length==secondString.Length)
            {
                char[] ch1 = (firstString.ToLower()).ToCharArray();
                char[] ch2 = (secondString.ToLower()).ToCharArray();

                Array.Sort(ch1);
                Array.Sort(ch2);

                String s1 = new string(ch1);
                String s2 = new string(ch2);

                if (s1==s2)
                {
                    Console.WriteLine("Strngs are anagram",firstString,secondString);
                }
                else
                {
                    Console.WriteLine("Strings are not anagram");
                }
            }
            else
            {
                Console.WriteLine("Strings are not  anagram",firstString,secondString);
            }
        }
    }

    class Fibonacci
    {
        static void Main(string[] args)
        {
            int i, count, n1 = 0, n2 = 1, n3;
            Console.WriteLine("Enter upper limit");
            count = int.Parse(Console.ReadLine());

            Console.WriteLine("----Fiboacci Series for Upper Limit------");

            Console.WriteLine(n1);
            //Console.WriteLine(n2);

            for(i=0;i<=count;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);

                n1 = n2;
                n2 = n3;
            }
        }
    }
}
