using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class DigiCount
    {
        static int countDigit(long n)
        {
            int count = 0;
            while (n!=0)
            {
                n = n / 10;
                ++count;
            }
            return count;
        }
        public  static void Main()
        {
            long n;
             n = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of  digits"+countDigit( n));
        }
    }
}
