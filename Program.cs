using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] exampleArray = new int[] { 93, 23, 12, 65, 22, 68, 47 };

            Console.Write("Before sorting: ");

            foreach (int element in exampleArray)
            {
                Console.Write(element + " ");
            }

            SelectionSort.Sort(exampleArray);

            Console.WriteLine();
            Console.Write("After sorting: ");

            foreach (int element in exampleArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
