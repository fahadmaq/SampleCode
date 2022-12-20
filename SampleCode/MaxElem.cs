using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class MaxElem
    {
        public  void FindElem(int[,]s)
        {
            for (int i=0;i<s.GetLength(0);i++)
            {
                int maxmum = s[0, 1];
                for (int j = 0; j < s.GetLength(1); j++)
                {
                    if(s[i,j]>maxmum)
                    {
                        maxmum = s[i, j];
                    }
                }
                Console.WriteLine(maxmum);
            }
        }

        static void Main(string[] args)
        {
            int[,] arr =
            {
                {4,8,87,6 },
                {2,7,35,4 },
                {6,8,2,100 },
                {4,9,56,12 }
            };
            MaxElem N = new MaxElem();
            N.FindElem(arr);
        }

    }
}
