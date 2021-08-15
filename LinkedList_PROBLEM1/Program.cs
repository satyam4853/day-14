using System;

namespace LinkedList_PROBLEM1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome to Linked List Problem----------");
            
            LinkedList list = new LinkedList {};
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            Console.WriteLine("The list in ascending order :");
            list.Display();




        }
    }
}











