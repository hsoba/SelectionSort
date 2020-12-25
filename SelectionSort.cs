using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
     public class SelectionSort
    {
        public static void Sort(int[] inputArray)
        {
            int arraySize = inputArray.Length;
            int i, j, temp, minIndex;

            // One by one move boundary of unsorted subarray
            for (i = 0; i < arraySize - 1; i++)
            {
                // Find the minimum index in the unsorted array
                minIndex = i;
                for (j = i + 1; j < arraySize; j++)
                {
                    if (inputArray[j] < inputArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the 1st element
                temp = inputArray[minIndex];
                inputArray[minIndex] = inputArray[i];
                inputArray[i] = temp;
            }
        }
    }
}
