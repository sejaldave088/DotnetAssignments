using System;


using System.Numerics;
using System.Linq;
using System.Diagnostics;

namespace sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            var a = "";

            Console.WriteLine("Enter the numbers: ");
            a = Console.ReadLine();
            string[] c = a.Split("+"); //use of split function for separate the numbers in a string array.
            for (int i = 0; i < c.Length; i++)
            {
                int b = 0;
                int.TryParse(c[i], out b); //convert the string into integer
                sum += b; //increment the sum and store into b.

            }
            Console.WriteLine(sum);
        }
    }
}