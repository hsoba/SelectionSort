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

            int i, j, temp, max;

            for (i = 0; i < arraySize - 1; i++)     // loop through the whole array except last index
            {
                max = 0;
                for (j = 1; j < arraySize - i - 1; j++)
                {
                    if (inputArray[j] > inputArray[max])
                    {
                        max = j;
                    }
                }

                temp = inputArray[arraySize - i - 1];
                inputArray[arraySize - i - 1] = inputArray[max];
                inputArray[max] = temp;
            }
        }
    }
}
