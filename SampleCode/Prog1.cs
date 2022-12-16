using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Prog1
    {
        public class Company : IComparable
        {
            private string emp;
            private int salary;
            public Company(string emp, int salary)
            {
                this.emp = emp;
                this.salary = salary;
            }
            public int CompareTo(object obj)
            {
                Company e3 = (Company)obj;
                if (this.salary > e3.salary)
                {
                    return 1;
                }
                else if (this.salary < e3.salary)
                {
                    return -1;

                }
                else
                {
                    return 0;

                }

            }
            public override string ToString()
            {
                return $"{emp}->{ salary}";
            }

        }
        public class Team : IEnumerable
        {
            private Company[] Employeees;
            public Team()
            {
                Employeees = new Company[5];
                Employeees[0] = new Company("mpo", 50);
                Employeees[1] = new Company("bnv", 60);
                Employeees[2] = new Company("jkh", 40);
                Employeees[3] = new Company("rgd", 30);
                Employeees[4] = new Company("far", 70);
            }
            public IEnumerator GetEnumerator()
            {
                return Employeees.GetEnumerator();
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                Team team = new Team();
                foreach (Company a in team)
                {
                    Console.WriteLine(a);
                }

                // Employeees = new Company[5];
                Company Employeees0 = new Company("mpo", 50);
                Company Employeees1 = new Company("bnv", 60);
                Company Employeees2 = new Company("jkh", 40);
                Company Employeees3 = new Company("rgd", 30);
                Company Employeees4 = new Company("far", 70);

                int result = Employeees1.CompareTo(Employeees4);

                if (result == 1)
                {
                    Console.WriteLine("bnv salary is more");
                }
                else if (result == -1)
                {
                    Console.WriteLine("bnv has leess salary");
                }
                else
                {
                    Console.WriteLine("both same salary");
                }
            }
        }
    }
}
