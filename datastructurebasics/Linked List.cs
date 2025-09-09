using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructurebasics
{
    internal class Linked_List<T>
    {
        public class Node<T>
        {
            public T item;
            public Node<T> next;
            public Node(T value)
            {
                item = value;
                next = null;
            }
        }
        public Node<T> head;
        public Node<T> tail;
        public int length = 0;
        public void InsertFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = tail = newNode;
                newNode.next = null;
                length++;
            }
            else
            {
                newNode.next = head;
                head = newNode;
                length++;
            }
        }
        public void InsertLast(T value)
        {
            Node<T> newNode = new Node<T>(value); // create a new node
            if (head == null)
            {
                head = newNode;
                newNode.next = null;
                length++;
            }
            else
            {
                Node<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;         // link the last node to the new node
                newNode.next = null;
                length++;
            }
        }
        // O(1) if we use tail
        /* Node<T> newNode = new Node<T>(value); // create a new node
        * if (head == null){
        *      head = tail = newNode;
        *      newNode.next = null;
        *      length++;}
        * else{
        *      tail.next = newNode;         // link the last node to the new node
        *      newNode.next = null;
        *      tail = newNode;
        *      length++;}*/
        public void InsertAtPossision(T value, int pos)
        {
            Node<T> newNode = new Node<T>(value);
            if (pos == length)
            {
                InsertLast(value);
            }
            else if (pos == 0)
            {
                InsertFirst(value);
            }
            else if (pos > length || pos < 0)
            {
                Console.WriteLine("Invalid position");
            }
            else
            {
                Node<T> current = head;
                for (int i = 1; i < pos - 1; i++)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
                length++;
            }

        }
        public void PrintList()
        {
            Node<T> current = head;
            Console.Write("List: ");
            while (current != null)
            {
                Console.Write(current.item + " -> ");
                current = current.next;
            }
            Console.WriteLine("null");
        }
        public void removeFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            head = head.next;
            length--;
        }
        public void removeLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head.next == null)
            {
                head = null;
                length--;
                return;
            }
            Node<T> current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            current.next = null;
            length--;
        }
        public int Size()
        {
            return length;
        }
        public void Remove(T item)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head.item.Equals(item))
            {
                head = head.next;
                length--;
                return;
            }
            Node<T> current = head;
            while (current.next != null && !current.next.item.Equals(item))
            {
                current = current.next;
            }
            if (current.next == null)
            {
                Console.WriteLine("Item not found");
                return;
            }
            current.next = current.next.next;
            length--;

        }
        public void Revrse()
        {
            Node<T> prev = null;
            Node<T> current = head;
            Node<T> next = null;
            // Iterate through the list and reverse the links
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            // Finally, update the head to point to the new first node
            head = prev;
        }
        public void Search(T item)
        {
            int pos = 0;
            while (head != null)
            {
                if (head.item.Equals(item))
                {
                    Console.WriteLine($"Item {item} found at possion {pos}");
                    return;
                }
                head = head.next;
                pos++;
            }
            Console.WriteLine($"Item {item} not found");

        }
    }
}
