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
            list.Add(30);
            list.Add(70);
           
          
           list.Display();
            //if (list.search(list.head, 56))
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            list.Insert(3, 40);
            Console.WriteLine("After inserting values:");
            list.Display();












        }
    }
}
