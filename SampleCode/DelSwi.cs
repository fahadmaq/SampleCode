using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace SampleCode
{
    class DelSwi
    {
        public delegate int Mydel(int n1, int n2);

        public class Test
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Multiply(int a,int b)
            {
                return a * b;
            }
            public int Sub(int a, int b)
            {
                return a - b;
            }
        }
        public class Helper
        {
            public event Mydel1 Addition;
            public event Mydel1 Subtractraction;
            public event Mydel1 Multiplication;

            public int M1 (int a ,  int b)
            {
                return Addition(a, b);

            }
            public int M2(int a , int b)
            {
                return Subtractraction(a, b);

            }
            public int M3(int a, int b)
            {
                return Multiplication(a, b);

            }


        }
        public class Program
        {
            static void Main(string[] args)
            {
                Test test = new Test();
                Helper h = new Helper();

                h.Addition += new Mydel1(test.Add);

                h.Subtractraction += new Mydel1(test.Sub);

                h.Multiplication += new Mydel1(test.Multiply);



            }
        }
    }
}*/
