using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Occurence
    {
        static int Occcurence(string str, string str1)
        {
            string[] a = str.Split(' ');
            int count = 0;
            for  (int i=0;i<a.Length;i++)
            {
                if (str1.Equals(a[i]))
                    count++;

            }
            return count;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("give string");
            string str = Console.ReadLine();
            Console.WriteLine("enter name");
            string str1 = Console.ReadLine();
            Console.WriteLine(Occcurence(str,str1));
        }
    }
    class ToggleChar
    {
        static void ToggleCharacter(char[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    str[i] = (char)(str[i] + 'a' - 'A');
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    str[i] = (char)(str[i] + 'A' - 'a');
                }

            }
        }
        static void Main(string[] args)
        {
            char[] str = "FaHAdd".ToCharArray();
            Console.WriteLine(str);
            ToggleCharacter(str);
            Console.WriteLine("string togggled");
            Console.WriteLine(string.Join(" ", str);
        }
    }


}
