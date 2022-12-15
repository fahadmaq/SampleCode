using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Ques
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(20);
            queue.Enqueue(40);
            queue.Enqueue(60);

            queue.Dequeue();

            Console.WriteLine("firs elem"+queue.Peek());

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }  

        }
    }
}
