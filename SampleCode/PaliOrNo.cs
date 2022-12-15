using System;
using System.Collections; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
     class PaliOrNo
    {
        static void Main(string[] args)
        {
            string rev = " ";
            string str = Console.ReadLine();
            char[] ch = str.ToArray();
            Array.Reverse(ch);
            rev = new string(ch);

            bool a = str.Equals(rev);
            if(a==true)
            {
                Console.WriteLine("String is Pali");
            }
            else
            {
                Console.WriteLine("Strin is not PAli");
            }
        }
    }
}
