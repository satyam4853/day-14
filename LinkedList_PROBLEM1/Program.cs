using System;

namespace LinkedList_PROBLEM1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome to Linked List Problem----------");
            // use case 1
            LinkedList list = new LinkedList { };
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();

        }
    }
}
