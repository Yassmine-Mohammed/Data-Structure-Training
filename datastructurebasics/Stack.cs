using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace datastructurebasics
{
    //Stack : 1) Array based implementation of the ADT stack

    /*
    public class Stack
    {
        int top;
        const int maxSize = 100;
        int[] stackArray = new int[maxSize];
        public Stack()
        {
            top = -1;
        }
        public void Push(int Elemnt)
        {
            if (top >= maxSize - 1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                stackArray[++top] = Elemnt;
            }
        }
        // remove the top
        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return -1; // or throw an exception
            }
            else
            {
                return stackArray[top--];
            }
        }
        // save a copy & remove the top 
        public void Pop(ref int Element)
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                stackArray[top--] = Element;
            }
        }
        public void GetTheTop()
        {
            Console.WriteLine("The top of the stack is:"+stackArray[top]);
        }
        // Print stack items
        public void Print ()
        {
            Console.Write("[ ");
            for (int i = top; i >= 0; i--)
            { 
                Console.Write(stackArray[i]+" ");            
            }
            Console.Write("]");

        }

    }
    */
   
    //========================================================================================================================

    // stack 2) Linked list impelemnt 
    /*
    class Node <T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    class StackLinkedList<T>
    {
        private Node<T> top;

        public StackLinkedList()
        {
            top = null;
        }

        // Push: إضافة عنصر فوق
        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);    // إنشاء عقدة جديدة
            if(newNode == null)
            {
                Console.Write("Stack push cannot allocate memory."); 
            }
            else 
            { 
            newNode.Next = top;                     // ربط العقدة الجديدة بالعقدة العلوية الحالية
            top = newNode;                          // تحديث العقدة العلوية لتكون العقدة الجديدة
            }
        }

        // Check if empty
        public bool IsEmpty()
        {
            return top == null;
        }

        // Pop: إزالة العنصر العلوي
        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty!");

            Node<T> temp = top; // حفظ العقدة العلوية مؤقتًا
            top = top.Next;     // تحديث العقدة العلوية لتكون العقدة التالية
            return temp.Data;   // إرجاع بيانات العقدة التي تمت إزالته
        }
       
        // Peek: إرجاع العنصر العلوي بدون إزالته
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty!");

            return top.Data;
        }

        public void display()
        {
            Node<T> current = top;
            Console.WriteLine("Stack elements:");
            Console.Write(" [");
            while (current != null)
            {
                Console.Write(current.Data +" ");
                current = current.Next;
            }
            Console.WriteLine("].");

        }

    }
    */


}
