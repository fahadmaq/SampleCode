using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Hasttabe
    {
        static void Main(string[] args)
        {


            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "USA");
            hashtable.Add(8, "DFG");
            hashtable.Add(9, "KJH");
            hashtable.Add(0, "UIP");
            hashtable.Add(3, "OJL");

            hashtable.Add("Test", 200);

            hashtable.Remove("Test");

            foreach (DictionaryEntry item in hashtable)

            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("**********************************************");

            SortedList sortedList = new SortedList();
            sortedList.Add(1, "USA");
            sortedList.Add(3, "USA");
            sortedList.Add(5, "USA");
            sortedList.Add(9, "USA"); 
            sortedList.Add(4, "USA");
            sortedList.Add(8, new Emp { ID = 1, name = "fah", salary = 45 });

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key+""+ item.Value);
            }

            Console.WriteLine("++++++++++EndHere++++++++++++++++");
        }
    }
}
