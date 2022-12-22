using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Delg2
    {
        public delegate void MyDel();
        public class Student
        {
            public event MyDel Pass;
            public event MyDel Fail;
            public void Accept(int marks)
            {
                if (marks>=40)
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
                Console.WriteLine("Hurray!! Passed");
            }
            public static void FailMessage()
            {
                Console.WriteLine("Awww! Failed");
            }

        }
        public class Program
        {
            static void Main(string[] args)
            {
                Student s1 = new Student();
                s1.Pass += new MyDel(Message.PassMessage);
                s1.Fail += new MyDel(Message.PassMessage);

                s1.Accept(64);
            }
        }
    }
}
