using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting
{
    class Sort
    {
        //Bubble sorting method
        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > 0; j--)
                {
                    int temp = 0;
                    if (array[j] < array[j - 1])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
            return array;
        }

        //Selection sorting method
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = array[min];
                    array[min] = array[i];
                    array[i] = temp;
                }
            }
            return array;
        }
        //Insertion sorting method
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
            }
            return array;
        }
        //Quick sorting method
        public static int[] QuickSort(int[] array, int first, int last)
        {
            int mid, count;
            int f = first, l = last;
            mid = array[(f + l) / 2]; 
            do
            {
                while (array[f] < mid) f++;
                while (array[l] > mid) l--;
                if (f <= l) 
                {
                    count = array[f];
                    array[f] = array[l];
                    array[l] = count;
                    f++;
                    l--;
                }
            } while (f < l);
            if (first < l) QuickSort(array, first, l);
            if (f < last) QuickSort(array, f, last);
            return array;
        }

     
        //bubble sorting time count
        public static void BubbleTimeCount(int[] array)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            BubbleSort(array);
            timer.Stop();
            Console.WriteLine("\nBubble sorting takes: " + timer.ElapsedMilliseconds + " ms.");
        }
        //Selection sorting time count
        public static void SelectionTimeCount(int[] array)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            SelectionSort(array);
            timer.Stop();
            Console.WriteLine("\nSelection sorting takes: " + timer.ElapsedMilliseconds + " ms.");
        }
        //Insertion sorting time count
        public static void InsertionTimeCount(int[] array)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            InsertionSort(array);
            timer.Stop();
            Console.WriteLine("\nInsertion sorting takes: " + timer.ElapsedMilliseconds + " ms.");
        }
        //Quick sorting time count
        public static void QuickTimeCount(int[] array, int first, int last)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            QuickSort(array, first, last);
            timer.Stop();
            Console.WriteLine("\nQuick sorting takes: " + timer.ElapsedMilliseconds + " ms.");
        }
    }
}
