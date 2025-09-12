using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructurebasics
{
    internal class Algorithms
    {
       
        //Selection Sort
        public void SelectionSort(int[] arr)
        {

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap the found minimum element with the first element
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        //Bubble Sort
        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        //Insertion Sort
        public void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                // Move elements of arr[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        // merge sort
        public void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int mid = left + (right - left) / 2;
                // Recursively sort first and second halves
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                // Merge the sorted halves
                Merge(arr, left, mid, right);
            }
        }
        private void Merge(int[] arr, int left, int mid, int right)
        {
            // Find sizes of two subarrays to be merged
            int n1 = mid - left + 1;
            int n2 = right - mid;
            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            // Copy data to temp arrays L[] and R[]
            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, mid + 1, R, 0, n2);
            // Merge the temp arrays back into arr[l..r]
            int i = 0; // Initial index of first subarray
            int j = 0; // Initial index of second subarray
            int k = left; // Initial index of merged subarray
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            // Copy the remaining elements of L[], if there are any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            // Copy the remaining elements of R[], if there are any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
   
}
