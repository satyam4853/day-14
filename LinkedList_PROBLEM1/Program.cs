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
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            list.pop();
            list.Display();

        }
    }
}
