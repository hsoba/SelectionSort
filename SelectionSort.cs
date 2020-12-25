using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SelectionSort
    {
        private static bool More(int value1, int value2)
        {
            return value1 > value2;
        }

        public static void Sort(int[] inputArray)
        {
            int arraySize = inputArray.Length;

            int i, j, temp;
            int max = 0;

            for (i = 0; i < arraySize - 1; i++)     // loop through the whole array except last index
            {
                for (j = 0; j < arraySize - i - 1; j++)
                {
                    if (More(inputArray[j], inputArray[j + 1]) && max < inputArray[arraySize - i])
                    {
                        max = inputArray[j];
                    }
                }

                temp = inputArray[arraySize - i];
                inputArray[arraySize - i] = inputArray[j];
                inputArray[j] = temp;


            }
        }
    }
}
