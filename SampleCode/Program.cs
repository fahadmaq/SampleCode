using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
public class Empcount1
    {


        public class Employee
            {
                // members --> field / variable/ data member
                // method, constructor, property, idexer, event
                // default access is private
                private int empid;
                private string empname;
                private double basic, hra, da, pf, gross;
                public Employee(int empid, string empname, double basic)
                {
                    this.empid = empid; // this refers to the data member
                    this.empname = empname;
                    this.basic = basic;
                }
                public void CalculateSalary()
                {
                    hra = basic * 0.40;
                    da = basic * 0.20;
                    pf = basic * 0.12;
                    gross = (basic + hra + da) - pf;
                }
                // ToString() --> string representation of an object
                public override string ToString()
                {
                    return $"Employee id {empid}, emp name {empname} & gross salary of emp {gross}";
                }

                //public string Print()
                //{
                //    return $"Employee id {empid}, emp name {empname} & gross salary of emp {gross}";
                //}
                public double GetGrossSalary()
                {
                    return gross;
                }
            }


                    static void Main(string[] args)
                {
                    Employee emp = new Employee(101, "Emp1", 23000.55);
                    emp.CalculateSalary();
                    //string data=emp.Print();
                    //Console.WriteLine(data);
                    // or
                    Console.WriteLine(emp);
                }
        }
    class Empdet
    {
        static void Main(string[] args)
        {
            Empcount E1 = new Empcount("xyz", 56000, "india");
            Console.WriteLine(E1);
            Console.WriteLine(Empcount.GetCount());

        }
    }
    }


  /*class Stdclasss1
    {


        static void Main(string[] args)
        {
            Stdclass student = new Stdclass(74, "fahad", 51, 78, 477);
            student.CalculatePercentage();
            //string data=emp.Print();
            //Console.WriteLine(data);
            // or
            Console.WriteLine(student);
        }
    }
}*/

