using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace SampleCode
{
    public interface Ipayable
    /*{
        void PayTax()
    }
    public class PrivateJob : Ipayable
    {
        public void PayTax()
        {
            5%
        }
    }
    public class Business:Ipayable
    {
        6%
    }*/
    /*{
        string Pay();
    }
    public class Customer : Ipayable, IOrder
    {
        public string Pay()
        {
            return "Success";
        }
        public string Display()
        {
            return "";
        }
    }
    public interface IOrder
    {
        string Display();

    }
    public interface ICustomer
    {
        string Display();

    }
    public class Transaction : IOrder, ICustomer
    {
        string IOrder.Display()
        {
            return "order details";
        }
        string ICustomer.Display()
        {
            return "Customer Details";
        }
    }


     static void Main(string[]args)
    {
        IOrder order = new Transaction();
        Console.WriteLine(order.Display());
        ICustomer customer = new Transaction();
        Console.WriteLine(customer.Display());

        Customer c1 = new Customer();
        Console.WriteLine(c1.Pay());
    }
}*/