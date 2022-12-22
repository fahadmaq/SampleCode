using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class PairAddii
    {
        static void Main(string[] args)
        {
            int targnum;
            Console.WriteLine("enter target num");
            targnum = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[6];
            Console.WriteLine("Enter your array");

            for (int i = 0; i <6; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j <a.Length; j++)
                {
                    int sum = a[i] + a[j];
                    if (sum==targnum)
                    {
                        Console.Write("{i} + {j}",+sum);
                    }
                }

            }
        }
    }
}
