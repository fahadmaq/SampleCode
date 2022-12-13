using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
   public class Empcount
    {
        private int eid;
        private string ename, country;
        private double esal;
        private static int count;
        public Empcount(string ename,double esal, string country="india")
        {
            count++;
            eid = count;
            this.ename = ename;
            this.esal = esal;
            this.country = country;

        }
        public static int GetCount()
        {
            return count;

        }
        public override string ToString()
        {
            return $"{eid},{ename},{esal},{country}";

        }
    }
}
