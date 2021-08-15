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
        public void Insert(int position, int data)
        {
            Node node = new Node(data);

            if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }

            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }
      public  void deleteNode(int key)
        {
            // Store head node
            Node temp = head, prev = null;

            // If head node itself holds
            // the key to be deleted
            if (temp != null &&
                temp.data == key)
            {
                // Changed head
                head = temp.next;
                return;
            }

            // Search for the key to be
            // deleted, keep track of the
            // previous node as we need
            // to change temp.next
            while (temp != null &&
                   temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            // If key was not present
            // in linked list
            if (temp == null)
                return;

            // Unlink the node from linked list
            prev.next = temp.next;
        }

        public int getCount()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }



        internal Node pop()
        {
            if (this.head == null)
            {
                return null;

            }
            this.head = this.head.next;
            return this.head;
        }
        internal Node PopLast()
        {
            if (head == null)
            {
                return null;

            }
            if (head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;

        }

        






           public  bool search(Node head, int x)
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

