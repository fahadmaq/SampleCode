using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class NewList

    {
        public string custname { get; set; }
        public string custadd { get; set; }

        public int custaccno { get; set; }

        public string loantype { get; set; }
    }
    public class Account
    {
        public string acctype { get; set; }

        public int accno { get; set; }
        //public string accname { get; set; }

        public List<NewList> CustDet = new List<NewList>();

    }


    public class Program3

    {
        //acctype loaan type home  loan goald loan etc
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>()

            {
                new Account
                {
                    acctype = "savings",
                    //accname="xyzer",
                    //accno = 531,
                    CustDet =
                    {
                        new NewList { custaccno = 500, custadd = "pune", custname = "xyzer", loantype = "car" },
                        new NewList { custaccno = 500, custadd = "pune", custname = "xyzer", loantype = "gold" }
                    }
                },
                new Account
                {
                    accno = 563,
                    acctype = "current",
                    CustDet = { new NewList { custaccno = 563, custadd = "mumbay", custname = "raja", loantype = "home" } }
                },


            };

            foreach (Account a in list)
            {
                Console.WriteLine($"Accountno--{a.accno},AccType---{a.acctype}");
                foreach (NewList n in a.CustDet)
                {
                    Console.WriteLine($"CustomeName--{n.custname},CustomerAddress---{n.custadd},LoanTyp---{n.loantype},CustomerAccNO=={n.custaccno}");
                }
            }

        }
    }
}
