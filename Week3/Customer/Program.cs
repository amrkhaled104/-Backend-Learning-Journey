using System;
using System.Collections;
using System.Collections.Generic;
namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customerQueue = new Queue<string>();

            customerQueue.Enqueue("Ahmed");
            customerQueue.Enqueue("Mona");
            customerQueue.Enqueue("Khaled");
            customerQueue.Enqueue("Sara");
            customerQueue.Enqueue("Omar");

            Console.WriteLine("Processing customers...");

            while (customerQueue.Count > 0)
            {
                string currentCustomer = customerQueue.Dequeue();
                Console.WriteLine($"Serving customer: {currentCustomer}");
            }

            Console.WriteLine("All customers have been served.");
        }

    }
}
