using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructurebasics
{
   /* Stack : 1) Array based implementation of the ADT stack
   
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
        public void Print ()
        {
            for (int i = 0; i <top +1; i++)
            { 
                Console.WriteLine(i + ": " + stackArray[i]);            
            }
        }
    }
   */
            
}
