using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
   public  class Ext1
    {
        public void M1()
        {

        }
        public void M2()
        {

        }
    }
    public static class ExtClass
    {
        public static void M3(this Ext1 E1)
        {
            Console.WriteLine("M3 method");
        }
        public static void M4(this Ext1 E1, string name)
        {
            Console.WriteLine("M4 Method"+name);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Ext1 E1 = new Ext1();
            E1.M3();
            E1.M4("TQ");
        }
    }

}
