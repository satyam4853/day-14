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
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted Into Linked List ", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("position out of range");
            }
            Console.WriteLine("Insterted Line Value is " + data);
            return head;
        }
       
        internal Node pop()
        {
            if (this.head== null)
            {
                return null;

            }
            this.head = this.head.next;
            return this.head;
        }
        internal Node PopLast()
        {
            if (head==null)
            {
                return null;

            }
            if (head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while(NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;

        }

     

        public bool search(Node head, int x)
        {
            Node current = head; // Initialize current
            while (current != null)
            {
                if (current.data == x)
                    return true; // data found
                current = current.next;
            }
            return false; // data not found
        }





    }
}
