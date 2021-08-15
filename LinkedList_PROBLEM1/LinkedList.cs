using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_PROBLEM1
{
    class LinkedList
    {

        internal Node head;

        
        internal void Add(int data)
        {
            //Object of Node
            Node node = new Node(data);
            Node temp = head, a = null;
            while (temp != null && temp.data < node.data)
            {
                a = temp;
                temp = temp.next;
            }
            if (a == null)
                head = node;
            else
            {
                a.next = node;
            }
            node.next = temp;

        }

        internal void Display()
        {
            if (this.head == null)
                Console.WriteLine("list is empty.");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine("Data : " + temp.data);
                    temp = temp.next;
                }
            }
        }





    }
}

