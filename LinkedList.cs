using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListApp
{
    public class Node
    {
        public string val;
        public Node next;
        public Node(string value, Node curr_node)
        {
            this.val = value;
            this.next = curr_node;

        }

    }

    public class LinkedList
    {
        public Node head;
        public Node tail;
        public int length = 0;

        public LinkedList(string value)
        {
            this.head = new Node(value, null);
            this.tail = this.head;
            this.length = 1;
        }
        public void append(string newval)
        {
            var newNode = new Node(newval, null);
            this.tail.next = newNode;
            this.tail = newNode;
            this.length++;
        }

        public void prepend(string newval)
        {
            var newNode = new Node(newval, this.head);
            this.head = newNode;
            this.length++;
        }


        public void insert(int index, string newval)
        {
            var newNode = new Node(newval, null);
            int i = 0;

            if (this.length - 1 < index)
            {
                Console.WriteLine("Cannot insert at this index as the length is less than the index");
                return;
            }
            var curr_node = this.head;
            var prev_node = this.head;
            while (i <= index)
            {
                if (index == 0)
                {
                    this.prepend(newval);
                    return;
                }

                if (i == index)
                {
                    newNode.next = curr_node;
                    prev_node.next = newNode;
                    this.length++;
                }
                else
                {
                    prev_node = curr_node;
                    curr_node = curr_node.next;
                }
                i++;
            }
        }

        public void remove(int index)
        {
            int i = 0;

            if (index > this.length)
            {
                Console.WriteLine("Cannot insert at this index as the length is less than the index");
                return;
            }
            var curr_node = this.head;
            var prev_node = this.head;
            while (i <= index)
            {
                if (index == 0)
                {
                    this.head = this.head.next;
                    this.length--;
                    return;
                }


                if (i == index)
                {
                    curr_node = curr_node.next;
                    prev_node.next = curr_node;
                    this.length--;
                }
                else
                {
                    prev_node = curr_node;
                    curr_node = curr_node.next;
                }
                i++;
            }
        }




        public void printlist()
        {
            int i = 0;
            var curr_node = this.head;


            if (this.length == 0)
            {
                Console.WriteLine("No Items Exist");
                return;
            }

            while (i < this.length)
            {
                Console.WriteLine(curr_node.val);
                if (curr_node.next != null)
                {
                    curr_node = curr_node.next;
                }
                i++;
            }
        }


    }
}
