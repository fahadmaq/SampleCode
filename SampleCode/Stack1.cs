using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Stack1
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(46);
            stack.Push(58);
            stack.Push(45);

            stack.Pop();
            stack.Pop();
            Console.WriteLine("Top elemen"+stack.Peek());

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
