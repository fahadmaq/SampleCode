using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Ledgate
    {

        public delegate int Mydel1(int n1, int n2);
        public delegate string Mydel2(string s);

        public class Test
        {
            public int M1(int a,  int b)
            {
                return a + b;
            }
            public string M2(string name)
            {
                return name.ToUpper();
            }
            public int M3(int a, int b)
            {
                return a * b;
            }
            public int M4(int a, int b)
            {
                return a - b;
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Test t1 = new Test();
                Mydel1 d1 = new Mydel1(t1.M1);
                d1 += new Mydel1(t1.M3);
                d1 += new Mydel1(t1.M4);


                Delegate[] List = d1.GetInvocationList();

                foreach (Delegate item in List)
                {
                    Console.WriteLine(item.Method);
                    Console.WriteLine(item.DynamicInvoke(34,67));
                }

                //Mydel2 d2 = new Mydel2(t1.M2);

                //int sum = d1.Invoke(56, 78);
                //Console.WriteLine(sum);

                //string str = d2.Invoke("thunquo");
                //Console.WriteLine(str);
            }
        }
    }
}
