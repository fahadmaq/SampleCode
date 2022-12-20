using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class MinMaxArr
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 23, 56, 4, 74, 63, 41 };
            int min = 0, max = 0;
            for (int i = 0; i < arr.Length; i++)

            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i]>arr[j])
                    {
                        max = arr[i];
                    }
                    else if(arr[i]<arr[j])

                        {
                        min = arr[i];


                        }

                }

            }

            Console.WriteLine($"min-{min},  max-{max}");



        }


    }
}
