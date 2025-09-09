using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace datastructurebasics
{
    public class Program
    {
        static void Main(string[] args)
        {
          Double_Linked_List<int> dll = new Double_Linked_List<int>();
            dll.InsertFirst2(10);
            dll.InsertLast2(20);
            dll.InsertLast2(30);
            dll.InsertLast2(40);
            dll.InsertAt(2, 25);
            dll.PrintList2();
            Console.WriteLine("The legth of the list: "+dll.Length2());
            dll.RemoveFirst2();
            dll.RemoveLast();
            dll.PrintList2();
            Console.WriteLine("The legth of the list: " + dll.Length2());
            dll.RemoveAt(1);
            dll.PrintList2();
            Console.WriteLine("The legth of the list: " + dll.Length2());
            dll.ReversePrint();

        }
    }
}
