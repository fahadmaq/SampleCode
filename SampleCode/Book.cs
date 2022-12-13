using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Book
    {
        int id;
        string name;
        string author;
        int price;

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string Author
        {
            set
            {
                author = value;
            }
            get
            {
                return author;
            }
        }

        public int Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Id = 123;
            b.name = "C sharp";
            b.author = "FAHD";
            b.price = 250;

            Console.WriteLine("${0}{1}", b.Id, b.name);

        }
    }
}

