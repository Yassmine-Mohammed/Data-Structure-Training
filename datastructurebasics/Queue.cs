using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace datastructurebasics
{
    // Queue : 1) Array based implementation of the ADT queue
    /* internal class Queue
     {
         int rear, front, legth;
         int max;
         int[] queue;
         public Queue(int size)
         {
             if (size <= 0)
             {
                 throw new ArgumentException("Size must be greater than zero");
             }
             max = size;
             queue = new int[size];
             rear = max- 1;
             front =0;
             legth = 0;
         }
         public bool isFull()
         {
             return legth == max;
         }
         public bool isEmpty()
         {
             return legth == 0;
         }
         public void Enqueue(int value)
         {
             if (isFull())
             {
                 Console.WriteLine("Queue is full");
                 return;
             }
             rear = (rear + 1) % max; // circular increment
             queue[rear] = value;
             legth++;
         }
         public int Dequeue()
         {
             if (isEmpty())
             {
                 Console.WriteLine("Queue is empty");
                 return -1; // or throw exception
             }
             int value = queue[front];
             front = (front + 1) % max; // circular increment
             legth--;
             return value;
         }
         public void Display()
         {
             if (isEmpty())
             {
                 Console.WriteLine("Queue is empty");
                 return;
             }
             for (int i = 0; i < legth; i++)
             {
                 Console.Write(queue[(front + i) % max] + " ");
             }
             Console.WriteLine();
         }
         public int Size()
         {
             return legth;
         }
         public int Peek()
         {
             if (isEmpty())
             {
                 Console.WriteLine("Queue is empty");
                 return -1; // or throw exception
             }
             return queue[front];
         }
         public void Clear()
         {
             rear = max - 1;
             front = 0;
             legth = 0;
         }
         public void search(int elemnt)
         {
             for (int i = 0; i <= legth; i++)
             {
                 if (isEmpty())
                 {
                     Console.WriteLine("Queue is empty");
                     return;
                 }
                 if (queue[i] == elemnt)
                 {
                     Console.WriteLine("Element found at position: " + i);
                     return;
                 }
             }
         }
     }
    */
    //==================================================================================================================================
   /* //2) A Linked List impelementation of ADT Queue
    public class Node<T>{
            public T Data;
            public Node <T> Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

    class linkedQueue<T>
    {
        private Node<T> front, reare;
        private int legnth = 0;
        public bool IsEmpty()
        {
            return (front == null);
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (IsEmpty())
            {
                this.front = this.reare = newNode;
                legnth++;
                return;
            }
            this.reare.Next = newNode;
            this.reare = newNode;
            legnth++;
        }
        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
            }
            else if (this.front == null)
            {
                this.reare = null;
                legnth = 0;
            }
            else
            {
                this.front = this.front.Next;
                legnth--;
            }
        }
        public void GetFront()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty!");
            }
            Console.WriteLine($"The front of the Queue is: {front.Data}.");
        }
        public void Display()
        {
            Node<T> current = front;
            Console.Write("Queue elements:");
            Console.Write(" [ ");
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
                Console.WriteLine("].");
        }
        public void Getsize()
        {
            Console.WriteLine($"The size is: {legnth}");
        }
    }
*/
}
