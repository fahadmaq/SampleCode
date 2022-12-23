using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace SampleCode
{
    public class EventBank
    {
        public delegate void MyDel();
        public class Ban
        {
            public event MyDel ZeroBal;
           // public event MyDel Credit;
            //public event MyDel Insufficientbalanc;
            public event MyDel acoountbal;

            public Ban(double accountbal)
            {
                this.acoountbal = accountbal;  
            }

            public void Credit(double accbalance)
            {
                // this.accbalaance = accbalance;
                //amount = Balance + accbalance;
                // if (accbalance <= 0)
                //{
                //  Insufficientbalanc();
                //}
                //else
                //{
                //  Balance();
                //}

                accbalance = Credit + accbalance;
            }
            public void Debit(double amount)
            {
                if (Balance>double)
                {
                    if ()

                }
            }

            //public void Credit(int amount)
            //{
              //  amount=amount+Balance
            ///}
        }
        public static class Message
        {
            public static void DebitMessage()
            {
                Console.WriteLine("Amount Debited");
            }
            public static void CreditMessage()
            {
                Console.WriteLine("Amount Credited);
                }

            public static void insufficientbalancMessage()
            {
                Console.WriteLine("not  enough balanc");
            }
        }
        public class Program

        {
            static void Main(string[] args)
            {
                Ban b1 = new Ban(5000);
               // b1.Accept(500);
                b1.Credit += new MyDel(Message.CreditMessage);
                b1.Debit += new MyDel(Message.DebitMessage);
                b1.insufficientbalanc += new MyDel(Message.insufficientbalancMessage);

                b1.Accept(5);
            }
        }



    }
           
        

    
}


namespace SampleCode
{
    public delegate void MyDel();
    public class Bank
    {
        private double acbalance;
        public event MyDel InBal;
        public event MyDel Zero;
        public Bank(double acbalance)
        {
            this.acbalance = acbalance;
        }

        public void Debit(double amt)
        {
            if (amt > acbalance)
            {
                InBal();
            }
            else
            {
                acbalance -= amt;
                if (acbalance == 0)
                {
                    Zero();
                }
            }
        }
        public void Credit(double amt)
        {
            acbalance += amt;
        }
        public override string ToString()
        {
            return $"Current balance is {acbalance}";
        }
    }
    public static class Message
    {
        public static void InsufficientBalance()
        {
            Console.WriteLine("Insufficient Balance to withdraw");
        }
        public static void ZeroBalance()
        {
            Console.WriteLine("Cureent Account balance is Zero");
        }

    }
    public class Program
    {

        static void Main(string[] args)
        {
            Bank b1 = new Bank(5000);
            b1.InBal += new MyDel(Message.InsufficientBalance);
            b1.Zero += new MyDel(Message.ZeroBalance);
            Console.WriteLine("Credit of 1000");
            b1.Credit(1000);
            Console.WriteLine(b1);
            Console.WriteLine("Debit 15000");
            b1.Debit(15000);
            Console.WriteLine(b1);
            Console.WriteLine("debit 6000");
            b1.Debit(6000);
            Console.WriteLine(b1);
        }
    }

}*/

