using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    //take a number from user and calculate the sum of digit 
    class NewClass
    {
        static void Main(string[] args)
        {
            int num, sum = 0, m;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());

            while(num>0)
            {
                m = num % 10;
                sum = m + sum;
                num = num / 10;
            }
            Console.WriteLine("Sum="+sum);
        }
    }
}
