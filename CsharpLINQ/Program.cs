using System;
using System.Linq;

namespace CsharpLINQ
{
    class Program
    {
        //LINQ = Language-Integrated Query
        //the typical syntax for a LINQ query is: from... where... orderby... select...
        static void Main(string[] args)
        {
            //select all even numbers from the following array
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            var evenNumQuery =
                //Part1. perform the query on the numbers array. num represents an individual item in the array. 
                from num in numbers 
                //Part2. tests each num in the array to determine if the remainder of num divided by 2 is zero. If it is, then num is an even number.
                where (num % 2) == 0
                //Part3. select num selects all elements that satisfy the criteria and assigns the results to the evenNumQuery variable
                select num;

            foreach (int i in evenNumQuery)
            {
            Console.WriteLine("{0} is an even number", i);

            }


            Console.Read();
        }
    }
}
