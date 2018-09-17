using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        private Node head;
        public void AddToFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        public void AddToLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = new_node;
        }
        public Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void AddToAfter(int prev_node, int new_data)
        {
            Node temp = head;
            int i = 1;
            while (i < prev_node)
            {
                temp = temp.next;
                i++;
            }
            if (temp == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = temp.next;
            temp.next = new_node;
        }
        public void DeleteNode(int key)
        {
            Node temp = head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public void PrintAllNodes()
        {
            Console.Write($"Head -> ");
            Node PrintNode = head;
            do
            {
                Console.Write(PrintNode.data);
                Console.Write(" -> ");
                PrintNode = PrintNode.next;
            } while (PrintNode.next != null);
            Console.Write(PrintNode.data);
            Console.Write(" -> NULL");
        }
    }
}

