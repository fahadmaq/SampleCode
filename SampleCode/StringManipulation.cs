using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class StringManipulation
    {
        static void Main(string[] args)
        {
            string str1 = "HEllo to all";
            Console.WriteLine(str1.Length);
            string str2 = " welcomne  to zoneB";
            Console.WriteLine(str2.Length);
            string str = String.Concat(str1, str2);
            Console.WriteLine(str);
            bool result = str1.StartsWith("HEllo");
            Console.WriteLine(result);
            bool res = str2.EndsWith("zoneB");
            Console.WriteLine(  res);
            bool r = str1.Contains("all");
            Console.WriteLine(r);
            char[] ch = str1.ToCharArray();
            foreach (var item in ch)
            {
                Console.WriteLine(item);
            }
            int a = String.Compare(str1, str2);
            Console.WriteLine(a);
            
        }
    }
    public class StrtEq
    {
        static void Main(string[] args)
        {

            string str1 = "gst";
            string str2 = "csst";
            char[] ch = { 'r', 't', 'n' };
            object str3 = new String(ch);
            Console.WriteLine(  str3);
            bool res = str1.Equals(str3);
            Console.WriteLine(res);
            if(str1==str3)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
