using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity_exercises_and_running_time
{
    internal class Sortes
    {
        // Bubble sort
        public static void BubbleSort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool flag = false;
                if (!flag)
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            flag = true;
                        }
                    }
            }
        }

        // Selection sort
        public static void SelectionSort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = FindMin(array, i);
                if (i != min)
                {
                    temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
        }

        public static int FindMin(int[] array, int index)
        {
            int min = index;
            for (int i = index; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }
            return min;
        }

        // Insertion sort
        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while (j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }
    }
}
