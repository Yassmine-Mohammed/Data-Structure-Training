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
          int [] arr = { -50, 40, 20, 10, 0,30 };
            Console.Write("Original array: ");
            Console.Write("[");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.Write("]");
            Console.WriteLine();

            Algorithms algorithms = new Algorithms();
            algorithms.MergeSort(arr, 0, arr.Length - 1);
            Console.Write("Sorted array by merg store algorithm: ");
            Console.Write("[");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");
            Console.WriteLine();
        }
    }
}
