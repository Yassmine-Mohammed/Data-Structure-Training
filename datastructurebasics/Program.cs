using System;
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
           Linked_List<int> intList = new Linked_List<int>();
            intList.InsertFirst(10);
            intList.InsertLast(20);
            intList.PrintList();
            intList.InsertLast(30);
            intList.InsertFirst(0);
            intList.PrintList();
            intList.InsertAtPossision(15, 2);
            intList.PrintList();
            //==============================================================
            Linked_List<string> strList = new Linked_List<string>();
            strList.InsertFirst("Hello");
            strList.InsertLast("World");
            strList.PrintList();
            strList.InsertAtPossision("C#", 1);
            strList.PrintList();

        }
    }
}
