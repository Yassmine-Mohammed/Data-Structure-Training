using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructurebasics
{
    public class Double_Linked_List<T>
    {
        public class Doublenode<T>
        {
            public T item;
            public Doublenode<T> next;
            public Doublenode<T> prev;
        }
        Doublenode<T> head2;
        Doublenode<T> tail2;
        int length2 = 0;
        public void InsertFirst2(T value)
        {
            Doublenode<T> newNode = new Doublenode<T>();
            newNode.item = value;
            if (head2 == null)
            {
                head2 = tail2 = newNode;
                newNode.next = null;
                newNode.prev = null;
                length2++;
            }
            else
            {
                newNode.next = head2;
                head2.prev = newNode;
                head2 = newNode;
                length2++;
            }
        }
        public void InsertLast2(T value)
        {
            Doublenode<T> newNode = new Doublenode<T>();
            newNode.item = value;
            if (head2 == null)
            {
                head2 = tail2 = newNode;
                newNode.next = null;
                newNode.prev = null;
                length2++;
            }
            else
            {
                tail2.next = newNode;
                newNode.prev = tail2;
                newNode.next = null;
                tail2 = newNode;
                length2++;
            }
        }
        public void InsertAt(int index, T value)
        {
            if (index < 0 || index > length2)
            {
                Console.WriteLine("Index out of range");
                return;
            }
            if (index == 0)
            {
                InsertFirst2(value);
                return;
            }
            if (index == length2)
            {
                InsertLast2(value);
                return;
            }
            Doublenode<T> newNode = new Doublenode<T>();
            newNode.item = value;
            Doublenode<T> current = head2;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
            newNode.next = current.next;
            newNode.prev = current;
            current.next.prev = newNode;
            current.next = newNode;
            length2++;
        }
        public void PrintList2()
        {
            Doublenode<T> current = head2;
            Console.Write("List: ");
            while (current != null)
            {
                Console.Write(current.item + " <=> ");
                current = current.next;
            }
            Console.WriteLine("null");
        }

        public int Length2()
        {
            return length2;
        }
        //Remove (first - last - At)
        public void RemoveFirst2()
        {
            if (head2 == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head2 == tail2)
            {
                head2 = tail2 = null;
                length2--;
                return;
            }
            head2 = head2.next;
            head2.prev = null;
            length2--;
        }
        public void RemoveLast()
        {
            if (head2 == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head2 == tail2)
            {
                head2 = tail2 = null;
                length2--;
                return;
            }
            tail2 = tail2.prev;
            tail2.next= null;
            length2--;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index > length2)
            {
                Console.WriteLine("Index out of range");
                return;
            }
            if (index == 0)
            {
                RemoveFirst2();
                return;
            }
            if (index == length2)
            {
               RemoveLast();
                return;
            }
            Doublenode<T> current = head2;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            current.next.prev = current.prev;
            current.prev.next = current.next;
            length2--;

        }
        public void ReversePrint ()
        {
            Doublenode<T> current = tail2;
            Console.Write("Reversed List: ");
            while (current != null)
            {
                Console.Write(current.item + " <=> ");
                current = current.prev;
            }
            Console.WriteLine("null");
        }
    }
    
    

}
