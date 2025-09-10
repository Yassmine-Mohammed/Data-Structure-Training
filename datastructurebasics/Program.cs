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
          Tree <int> tree = new Tree<int>();
            tree.Add(50);
            tree.Add(30);
            tree.Add(70);
            tree.Add(20);
            tree.Add(40);
            tree.Add(60);
            tree.Add(80);
            tree.Display();
       }
    }
}
