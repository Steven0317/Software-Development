using System;
using System.Collections.Generic;

/*
 *  Steven Faulkner 
 *  U96161844 Assignment 1-2
 *  Small OOP project to get familiar with c#
 */
namespace Assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> IntList = new List<int>();

            int input;

            Console.Write("Enter any natural number: ");
            input = Convert.ToInt32(Console.ReadLine());

            //if first number is 0 we just exit
            if (input != 0) {

                IntList.Add(input);

                while (input != 0)
                {
                    Console.Write("Enter any natural number: ");
                    input = Convert.ToInt32(Console.ReadLine());
                    IntList.Add(input);
                }

                //remove the zero at the end of the list
                IntList.RemoveAt(IntList.Count - 1);

                int sum = 0;
                int max = IntList[0];
                int min = IntList[0];
                int lastElement = IntList.Count - 1;
                int firstElement = 0;

                //check for min and max while having to sum the elements
                foreach (int num in IntList)
                {
                    max = (max > num) ? max : num;
                    min = (min < num) ? min : num;
                    sum += num;
                }


                //output results
                Console.WriteLine("Sum of array elements: " + sum);
                Console.WriteLine("Minimum element in array: " + min);
                Console.WriteLine("Maximum element of arry: " + max);
                Console.WriteLine("Quotient: " + IntList[firstElement] / IntList[lastElement]);
                Console.WriteLine("Remainder: " + IntList[firstElement] % IntList[lastElement]);
            }

            Console.ReadKey();
        }
    }
}
