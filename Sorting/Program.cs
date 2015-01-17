using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
       
           
            Console.WriteLine("Hello, this program calculates the time of array sorting by different methods: ");
            Console.WriteLine(" - Bubble \n - Selection \n - Insertion \n - Quick sorting");
            Console.WriteLine("Do you want to start sorting? (y / n)");
            String userAnswer = Console.ReadLine().ToLower();

            while (userAnswer == "y")
            {
                //Asking for the number of elements to sort 
                int arrSize; //number of elements in array
                Console.WriteLine("How many values do you want to sort?");
                arrSize = Convert.ToInt32(Console.ReadLine());

                //Asking for left and right array borders
                int leftBorder, rightBorder;

                Console.WriteLine("Type in the minimum value: ");
                leftBorder = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type in the maximum value: ");

                rightBorder = leftBorder;
                while (rightBorder <= leftBorder)
                {
                    rightBorder = Convert.ToInt32(Console.ReadLine());
                    if (rightBorder <= leftBorder)
                    {
                        Console.WriteLine("Right border Must be bigger than left border, \n Enter the right border again!");
                    }
                }

                //Creating an array of random integers within the selected range
                //creating random object
                Random rnd = new Random();
                //creating  arrays to sort
                int[] randomValues1 = new int[arrSize];
                for (int i = 0; i < randomValues1.Length; i++)
                {
                    randomValues1[i] = rnd.Next(leftBorder, rightBorder);
                }
                var randomValues2 = (int[])randomValues1.Clone();
                var randomValues3 = (int[])randomValues1.Clone();
                var randomValues4 = (int[])randomValues1.Clone();

                //calling sorting and time measuring methods
                Sort.BubbleTimeCount(randomValues1);
                Sort.SelectionTimeCount(randomValues2);
                Sort.InsertionTimeCount(randomValues3);
                Sort.QuickTimeCount(randomValues4, 0, randomValues4.Length - 1);

                Console.WriteLine("Do you want to do another sorting? (y / n)");
                userAnswer = Console.ReadLine().ToLower();
                if(userAnswer == "y")
                {
                    Console.Clear();
                }
            }
            Console.WriteLine("Goodbye baby");
            Console.ReadKey();
        }



      }
}
