using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Ldel
    {
        public delegate void MyDel();
        public class  stud
        {
            public event MyDel Pass;
            public event MyDel Fail;
            public void Accept(int marks)
            {
                if(marks>=40)
                {
                    Pass();
                }
                else
                {
                    Fail();

                }
            }
        }
        public static class Message
        {
            public static void PassMessage()
            {
                Console.WriteLine("GReat PAssed!");
            }
            public static void FailMessage()
            {
                Console.WriteLine("Sorry Failed!");
            }

        }
        public  class Program
        {
            static void Main(string[] args)
            {
                stud s1 = new stud();

                s1.Pass += new MyDel(Message.PassMessage);
                s1.Fail += new MyDel(Message.FailMessage);

                s1.Accept(56);
            }
        }
    }
}
