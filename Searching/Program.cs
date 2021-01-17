using System;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = {10, 20, 80, 30, 60, 50,
                     110, 100, 130, 170};
            int element = 110;

            Console.WriteLine($"Element found at {LinearSearch.Search(inputArr, element)}");
            Console.WriteLine($"Element found at {LinearSearch.SearchImproved(inputArr, element)}");

            element = 175;

            Console.WriteLine($"Element found at {LinearSearch.Search(inputArr, element)}");
            Console.WriteLine($"Element found at {LinearSearch.SearchImproved(inputArr, element)}");
        }
    }
}
