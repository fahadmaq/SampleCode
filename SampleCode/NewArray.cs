using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class NewArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 54, 65, 89, 26, 74, 23, 45, 7 };
            int[] arr2 = new int[3];
            Array.Sort(arr);
            Array.Sort(arr, 3, 4);
            Array.Reverse(arr);
            Array.Copy(arr, arr2, 3);
            Array.Copy(arr, 5, arr2, 3, 3);
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
