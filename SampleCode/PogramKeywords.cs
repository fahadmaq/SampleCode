using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class PogramKeywords
    {
        static void AcceptNames(params string[] names)
        {
            Console.WriteLine("Values to print" + names.Length);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        static void Main(string[] args)
        {
            AcceptNames("amol", "kishor");
            AcceptNames("amol", "kishor", "xyz");
            AcceptNames("amol", "kishor", "xyz", "qwerty");
        }
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }
        public class Key1
        {

            static void Main(string[] args)
            {
                int a = 36, b = 96;
                Console.WriteLine($"Before call method a{a},b{b}");
                Swap(ref a, ref b);
                Console.WriteLine($"after call method a{a},b{b}");
            }
        }
        static void Calculate(int a, int b, out int sum, out int sub, out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;

        }
        public class Key2
        {
            static void Main(string[] args)
            {
                int a = 44, b = 89, sum, sub, mul;
                Calculate(a, b, out sum, out sub, out mul);
                Console.WriteLine(sum);
                Console.WriteLine(sub);
                Console.WriteLine(mul);
            }
        }
    }
}
